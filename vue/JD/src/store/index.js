import Vue from 'vue'//引用vue文件
import Vuex from 'vuex'//引用vuex文件
import Actions from './store/actions'
import Getters from './store/getters'
import Mutations from './store/mutations'
import State from './store/state'

Vue.use(Vuex);//全局注册使用

//定义状态属性，state 名字不可以写错

//管理mutations


//改变状态的值 mutations名字不能写错


//状态管理计算属性 getters 名字不能写错

//导出
export default new Vuex.Store({
    State,
    Mutations,
    Getters,
    Actions
});




