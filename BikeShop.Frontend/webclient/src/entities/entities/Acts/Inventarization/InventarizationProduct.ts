export interface InventarizationProduct {
    id: number,
    createdAt: string,
    updatedAt: string,
    enabled: true,
    inventariazationId: number,
    productId: number,
    name: string,
    description: string,
    catalogKey: string,
    barcode: string,
    manufBarcode: string,
    quantityUnitName: string,
    incomePrice: number,
    dealerPrice: number,
    retailPrice: number,
    quantity: number,
    incomeTotal: number,
    dealerTotal: number,
    retailTotal: number,
    userCreated: string,
    userUpdated: string
}