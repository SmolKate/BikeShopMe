import React from "react"
import { ObjType } from "./TableCreationModel"
import s from './TablePreviewModal.module.scss'
import { CustomModal } from "shared/ui/CustomModal/CustomModal"

// модалка для предпросмотра JSON объекта в виде таблицы

type TablePreviewModalProps = {
    isVisibleModal: boolean
    setIsVisibleModal: (isVisibleModal: boolean) => void
    data: ObjType[]
}

const TablePreviewModal = React.memo(({isVisibleModal, setIsVisibleModal, data}: TablePreviewModalProps) => {

    const handleModalClose = () => {
        setIsVisibleModal(false)
    }

    if (!isVisibleModal) return null

    return (
        <CustomModal className={s.modal} open={isVisibleModal} onClose={handleModalClose}>
            <div className={s.modal_dialog} onClick={e => e.stopPropagation()}>
                <div className={s.modal_header}>
                    <h3 className={s.modal_title}>Новый файл</h3>
                    <span className={s.modal_close} onClick={handleModalClose}>
                        &times;
                    </span>
                </div>
                <div className={s.modal_body}>
                    <div className={s.modal_content}>
                        <table className={s.modal_table}>
                            <thead>
                                <tr>
                                {Object.keys(data[0]).map(heading => {
                                    return <th key={heading}>{heading}</th>
                                })}
                                </tr>
                            </thead>
                            <tbody>
                                {data.map((row: any, index: any) => {
                                    return <tr key={index}>
                                        {Object.keys(data[0]).map((heading: any, index) => {
                                                return <td key={index}>{row[heading]}</td>
                                        })}
                                    </tr>;
                                })}
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </CustomModal>
    )

})

export default TablePreviewModal;