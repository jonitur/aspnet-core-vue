import CounterExample from 'components/counter-example'
import FetchData from 'components/fetch-data'
import CustomerList from 'components/customer-list'
import HomePage from 'components/home-page'

export const routes = [
    { path: '/', component: HomePage, display: 'Home', style: 'glyphicon glyphicon-home' },
    { path: '/counter', component: CounterExample, display: 'Counter', style: 'glyphicon glyphicon-education' },
    { path: '/fetch-data', component: FetchData, display: 'Fetch data', style: 'glyphicon glyphicon-th-list' },
    { path: '/customer-list', component: CustomerList, display: 'Customer list', style: 'glyphicon glyphicon-th-list' },
    { path: '/orders', component: FetchData, display: 'Orders list', style: 'glyphicon glyphicon-th-list' },  
]