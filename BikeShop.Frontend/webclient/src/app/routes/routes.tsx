import {BikeShopPaths} from './paths'
import {createBrowserRouter} from 'react-router-dom'
import {
    AdminControl,
    Cashbox,
    Catalog,
    CatalogProductItem,
    InventarizationPage,
    LoginPage,
    MainPage,
    Order,
    ProductCatalog,
    Profile,
    RegistrationPage,
    Service,
    ShopMain,
    ShopWrapper,
    StorageProductsTransfer,
    StuffProfile,
    SupplyInvoice,
    WorkCatalog
} from '../../pages'
import {OnlyWithoutAuthRoute, WorkspaceHeaderProvider} from '../../entities'
import {
    BarcodeScannerListenerProvider
} from 'app/providers/BarcodeScannerListenerProvider/BarcodeScannerListenerProvider'
import {CheckAuthEmployee} from "../providers/RouteProviders/CheckAuthEmployee"
import PublicOfferPage from "../../pages/public/Shop/InfoPages/PublicOfferPage";
import AboutUsPage from "../../pages/public/Shop/InfoPages/AboutUsPage";
import DeliveryPayment from "../../pages/public/Shop/InfoPages/DeliveryPayment";
import TableCreationModel from 'features/TableCreationModal/TableCreationModel'

// @ts-ignore
export const routes = createBrowserRouter([

    ////                    ////
    ////    Авторизация     ////
    ////                    ////

    {
        path: BikeShopPaths.COMMON.LOGIN,
        element: <OnlyWithoutAuthRoute>
            <LoginPage/>
        </OnlyWithoutAuthRoute>
    },
    {
        path: BikeShopPaths.COMMON.REGISTRATION,
        element: <OnlyWithoutAuthRoute>
            <RegistrationPage/>
        </OnlyWithoutAuthRoute>
    },

    ////                                        ////
    ////          Интернет-магазин              ////
    ////                                        ////

    {
        path: '/',
        element: <ShopWrapper>
            <ShopMain/>
        </ShopWrapper>

    },
    {
        path: BikeShopPaths.SHOP.HOME,
        element: <ShopWrapper>
            <ShopMain/>
        </ShopWrapper>
    },
    {
        path: BikeShopPaths.SHOP.CATALOG,
        element: <ShopWrapper>
            <Catalog/>
        </ShopWrapper>
    },
    {
        path: BikeShopPaths.SHOP.PRODUCT,
        element: <ShopWrapper>
            <CatalogProductItem/>
        </ShopWrapper>
    },
    {
        path: BikeShopPaths.SHOP.PROFILE,
        element: <ShopWrapper>
            <Profile/>
        </ShopWrapper>
    },
    {
        path: BikeShopPaths.SHOP.ORDER,
        element: <ShopWrapper>
            <Order/>
        </ShopWrapper>
    },
    {
        path: BikeShopPaths.SHOP.PUBLIC_OFFER,
        element: <ShopWrapper>
            <PublicOfferPage/>
        </ShopWrapper>
    },
    {
        path: BikeShopPaths.SHOP.ABOUT_US,
        element: <ShopWrapper>
            <AboutUsPage/>
        </ShopWrapper>
    },
    {
        path: BikeShopPaths.SHOP.DELIVERY_INFO,
        element: <ShopWrapper>
            <DeliveryPayment/>
        </ShopWrapper>
    },

    ////                                        ////
    ////    Страницы только для залогиненых     ////
    ////                                        ////

    {
        path: BikeShopPaths.WORKSPACE.MAIN_PAGE,
        element: <CheckAuthEmployee>
            <BarcodeScannerListenerProvider>
                <WorkspaceHeaderProvider>
                    <MainPage/>
                </WorkspaceHeaderProvider>
            </BarcodeScannerListenerProvider>
        </CheckAuthEmployee>
    },
    {
        path: BikeShopPaths.WORKSPACE.CASHBOX,
        element: <CheckAuthEmployee>
            <WorkspaceHeaderProvider>
                <Cashbox/>
            </WorkspaceHeaderProvider>
        </CheckAuthEmployee>
    },
    {
        path: BikeShopPaths.WORKSPACE.SERVICE,
        element: <CheckAuthEmployee>
            <WorkspaceHeaderProvider>
                <Service/>
            </WorkspaceHeaderProvider>
        </CheckAuthEmployee>
    },
    {
        path: BikeShopPaths.WORKSPACE.PRODUCT_CATALOG,
        element: <CheckAuthEmployee>
            <WorkspaceHeaderProvider>
                <ProductCatalog/>
            </WorkspaceHeaderProvider>
        </CheckAuthEmployee>
    },
    {
        path: BikeShopPaths.WORKSPACE.WORK_CATALOG,
        element: <CheckAuthEmployee>
            <WorkspaceHeaderProvider>
                <WorkCatalog/>
            </WorkspaceHeaderProvider>
        </CheckAuthEmployee>
    },
    {
        path: BikeShopPaths.WORKSPACE.ARRIVAL_OF_PRODUCTS,
        element: <CheckAuthEmployee>
            <WorkspaceHeaderProvider>
                <SupplyInvoice/>
            </WorkspaceHeaderProvider>
        </CheckAuthEmployee>
    },
    {
        path: BikeShopPaths.WORKSPACE.INVENTARIZATION,
        element: <CheckAuthEmployee>
            <WorkspaceHeaderProvider>
                <InventarizationPage/>
            </WorkspaceHeaderProvider>
        </CheckAuthEmployee>
    },
    {
        path: BikeShopPaths.WORKSPACE.STORAGE_PRODUCTS_TRANSFER,
        element: <CheckAuthEmployee>
            <WorkspaceHeaderProvider>
                <StorageProductsTransfer/>
            </WorkspaceHeaderProvider>
        </CheckAuthEmployee>
    },
    {
        path: BikeShopPaths.WORKSPACE.PROFILE,
        element: <CheckAuthEmployee>
            <WorkspaceHeaderProvider>
                <StuffProfile/>
            </WorkspaceHeaderProvider>
        </CheckAuthEmployee>
    },
    {
        path: BikeShopPaths.WORKSPACE.ADMIN,
        element: <CheckAuthEmployee>
            <WorkspaceHeaderProvider>
                <AdminControl/>
            </WorkspaceHeaderProvider>
        </CheckAuthEmployee>
    },

    {
        path: BikeShopPaths.WORKSPACE.CHECK_MODEL,
        element: <TableCreationModel />
    },

    // {
    //     path: BikeShopPaths.WORKSPACE.SHOP_CHECK,
    //     element: <CheckForShop/>
    // },
    // {
    //     path: BikeShopPaths.WORKSPACE.WORK_CHECK,
    //     element: <CheckForServiceWork/>
    // },
    // {
    //     path: BikeShopPaths.WORKSPACE.WORK_ACT,
    //     element: <ActServiceWork/>
    // },
    // {
    //     path: BikeShopPaths.WORKSPACE.GET_STUFF_TO_SERVICE_ACT,
    //     element: <ServiceIncomeInvoice/>
    // },
    // {
    //     path: BikeShopPaths.WORKSPACE.GET_STUFF_FROM_SERVICE_ACT,
    //     element: <ActGetStuffFromService/>
    // },
])