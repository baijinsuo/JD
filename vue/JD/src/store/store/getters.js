
//状态管理计算属性 getters 名字不能写错
var getters={
    count(state){
        return state.count;
    },
    isEvenOrOdd(state){
        return state.count % 2 ?'基数':'偶数';
    }
}
//导出
export default getters;




