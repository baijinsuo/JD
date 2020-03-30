import Vue from 'vue'
import Router from 'vue-router'
import Home from '../components/home/home'
import Cart from '../components/cart/cart'
import Find from '../components/find/find'
import Mine from '../components/mine/mine'
import Catgory from '../components/catgory/catgory'
import Login from '../components/login/login'
import GoodsDetail from '../components/detail/GoodsDetail'
import Search from '../components/search/search'
import Register from '../components/register/register'
import Login1 from '../components/login/index'


Vue.use(Router)

export default new Router({
  linkActiveClass:'active',
  routes: [
    {
      path: '/home',
      component: Home
    },
    {
      path: '/cart',
      component: Cart
    },
    {
      path: '/find',
      component: Find
    },
    {
      path: '/mine',
      component: Mine
    },
    {
      path: '/catgory',
      component: Catgory
    },
    {
      path: '/catgory/:id',
      component: Catgory
    },
    {
      path: '/login/:id',
      component: Login
    },
    {
      path: '/login',
      component: Login
    },
    {
      path:'/detail/:id',
      component:GoodsDetail
    },
    {
      path:'/search',
      component:Search
    },
    {
      path:'/register',
      component:Register
    },
    {
      path:'/',
      redirect:'/home'//重定向到某个页面
    }
  ]
})
