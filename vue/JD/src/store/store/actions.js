//管理mutations
var actions={
    add({commit,state}){
        commit('add');
    },
    remove({commit,state}){
        if(state.count > 3){ //判断状态里面的count值，大于3的时候出发 mutations ->remove方法
             commit('remove');
        }
    }
}



//导出
export default actions;



