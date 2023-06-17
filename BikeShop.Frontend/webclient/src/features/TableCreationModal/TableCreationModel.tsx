import React, {useState} from 'react'
import s from './TableCreationModal.module.scss'
import * as XLSX from 'xlsx'
import TablePreviewModal from './TablePreviewModal'
import {useSnackbar} from 'notistack'
import { Button } from 'shared/ui/Button/Button'
import { CustomInput } from 'shared/ui/CustomInput/CustomInput'
import { UniTable } from 'shared/ui/Table/UniTable'

// На вход приходит массив заголовков для создания новой таблицы. 
// В модалку загружается таблица, с помощью выпадающего списка для
// столбцов выбираются заголовки, после этого возможен предпросмотр новой таблицы, 
// а при нажатии кнопки Создать формируется JSON объект для дальнейшей обработки. 
// Cтолбцы с заголовками "Нет" отфильтровываются.

// !!! Первым элементом в массиве заголовков должно быть "Нет" !!!

type TableCreationModalType = {
    headersArray?: HeadersArrayType
}
type HeadersArrayType = string[]
export type ObjType = {
        [key: string]: string
    }

const TableCreationModal: React.FC<TableCreationModalType> = ({headersArray = ['Нет', 'Product', 'pcs', 'Manufacturer']}) => {

    const {enqueueSnackbar} = useSnackbar()
    
    let [fileName, setFileName] = useState('')
    let [tableData, setTableData] = useState([] as ObjType[])
    let [newTableData, setNewTableData] = useState([] as ObjType[])
    let [newHeadings, setNewHeadings] = useState({} as ObjType)
    let [isVisibleModal, setIsVisibleModal] = useState (false as boolean)

    type TableDataType = typeof tableData[0]
    
    // Выбор файла и преобразование данных в JSON объект. 
    // Допустимые форматы: .xlsx, .xls, .csv, .xlsm, .ods
    const handleFileSelected = (e: React.ChangeEvent<HTMLInputElement>) => {
        if (!!e.target.files) {
            setFileName(e.target.files[0].name)
            let reader = new FileReader()
            reader.onload = (e: any) => {
                const data = e.target.result
                const workbook = XLSX.read(data, { type: "array" })
                const sheetName = workbook.SheetNames[0]
                const worksheet = workbook.Sheets[sheetName]
                const json = XLSX.utils.sheet_to_json(worksheet) as ObjType[]
                setTableData(json)
            };
            reader.readAsArrayBuffer(e.target.files[0]) 
            console.log(tableData)      
        }
    }

    // Получение заголовков столбцов из первоначальной таблицы
    const getHeadings = (): string[] => {
        if (!!tableData && tableData.length != 0) {
        return Object.keys(tableData[0])
        }
        return []
      }

    // Формирование JSON файла с новыми заголовками. Включает в себя только те столбцы, 
    // для которых выбраны заголовки. Если выбраны не все заголовки, выпадает ошибка.
    const createFilteredJson = (): ObjType[] => {
        if (tableData.length == 0) {
            enqueueSnackbar('Выберете файл', {variant: 'error', autoHideDuration: 5000})
            return []
        }

        // Определение того, все ли заголовки были выбраны из входящего массива
        let statusOpt = [] as string[]
        let headersArrWithoutNone = headersArray.slice(1, headersArray.length)
        for (let header of headersArrWithoutNone) {
            if (!Object.values(newHeadings).includes(header)) {
                statusOpt.push(header)
            }
        }
        if (statusOpt.length != 0) {
            enqueueSnackbar('Не хватает следующих столбцов: ' + statusOpt.join(', '), {variant: 'error', autoHideDuration: 5000})
            return []
        }

        // Формирование JSON объекта с заменой заголовков на выбранные
        let arr = Object.keys(tableData[0]) as string[]
        let newJson = tableData.map((obj: TableDataType) => {
            return Object.fromEntries(arr.map(k => [newHeadings[k], obj[k]]))
        })

        // Фильтрация столбцов, для которых заголовки не выбраны
        let newJsonFilter = newJson.map( (obj: ObjType) => {
            delete obj['undefined']
            delete obj['Нет']
            return obj
        })
        return newJsonFilter
    } 

    // Обработчик выбора нового заголовка в input
    const handleChange = (e: React.ChangeEvent<HTMLSelectElement>) => {
        setNewHeadings(prevState => ({...prevState, [e.target.id]: e.target.value}))
    }

    // Обработчик нажатия кнопки Создать
    const handleCreate = () => {
        let newJsonFilter = createFilteredJson() as ObjType[]
        console.log(newJsonFilter)
    }

    // Обработчик нажатия кнопки Предпросмотр
    const handlePreview = () => {
        let newJsonFilter = createFilteredJson() as ObjType[]
        if (newJsonFilter.length != 0) {
            setNewTableData(newJsonFilter)
            setIsVisibleModal(true)
        }
    }

    // Формирование выпадающего списка, включающего все названия из того массива, 
    // который был получен на входе в модалку, для указания новых заголовков
    let header = headersArray.map ( (header: string, index: number) => <option key={index} id={index.toString()} value={header}>{header}</option>)

    return (<div className={s.tableCreationModal_out_container}>
        <div className={s.tableCreationModal_container}>
            <div className={s.tableCreationModal_header}>
                <label htmlFor="input_file">Выбрать файл</label>
                <input type="file" id="input_file" className={s.input_file} 
                    accept=".xlsx, .xls, .csv, .xlsm, .ods" onChange={handleFileSelected}></input>
                <CustomInput className={s.tableCreationModal_fileinput} value={fileName}></CustomInput>
                <CustomInput placeholder="Шаблон"></CustomInput>
                <Button onClick={handlePreview}>Предпросмотр</Button>
                <Button onClick={handleCreate}>Создать</Button>
            </div>
            <TablePreviewModal isVisibleModal={isVisibleModal} 
                                setIsVisibleModal = {setIsVisibleModal}
                                data={newTableData} />
            <div className={s.tableCreationModal_body_container}>
                <table className={s.tableCreationModal_body}>
                    <thead>
                        <tr>
                        {getHeadings().map(heading => {
                            return <th key={heading}>
                                        <select id={heading} name='header' defaultValue="Нет" onChange={handleChange}>
                                            {header}
                                        </select>
                                    </th>
                        })}
                        </tr>
                    </thead>
                    <tbody className={s.tableCreationModal_tbody}>
                        {tableData.map((row: any, index: any) => {
                            return <tr key={index}>
                                {getHeadings().map((heading: any, index) => {
                                        return <td key={index}>{row[heading]}</td>
                                })}
                            </tr>;
                        })}
                    </tbody>
                </table>
            </div>
        </div>
    </div>
)}

export default TableCreationModal
