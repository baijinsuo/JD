// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import store from './store/index.1'//导入Vuex
import axios from 'axios'
import VueLazyLoad from 'vue-lazyload' //安装完成lazyLoad以后导入lazyLoad
import App from './App'
import router from './router'
import './assets/css/base.css'
// import 'bootstrap/dist/css/bootstrap.min.css'

Vue.config.productionTip = false
//请求的服务器地址    
 axios.defaults.baseURL="http://39.96.88.23:8082/api/";
//http://39.96.88.23:8082
// axios.defaults.baseURL="http://39.96.88.23:8080/api/";

//请求头部设置
//axios.defaults.headers['Content-Type']='application/x-www-from-urlencoded';

//将第三方axios存在原型对象中
Vue.prototype.$http=axios;

//安装懒加载
//在项目文件根路径 cmd->cnpm install vue-lazyload
Vue.use(VueLazyLoad, {
  preload: 1.3, //表示lazyLoad距离页面底部的百分比
  error: require('./assets/images/err.png'),//图片加载失败后显示的加载失败图片路径
  loading: require('./assets/images/loading.gif'),//图片正在加载中显示的loading图片路径
  attempt: 1,//图片加载失败后的重试次数，默认为3
  listenEvents: ['scroll'] //默认是['scroll'] ['whell'] ['mousewhell'] ['resize'] ['animationend']
  //如果给这个属性只指定['touchmove'] 那么scroll屏幕不会加载图片，只有手指滑动才会加载图片
});

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  store,//引用vuex
  components: { App },
  template: '<App/>'
})
