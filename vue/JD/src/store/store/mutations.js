
//改变状态的值 mutations名字不能写错
var mutations={
    add(state){
        state.count++;
    },
    add1(state,sum){//sum表示传递过来的参数
        state.count+=sum;
    },
    remove(state){
        state.count-=1;
    }
}


//导出
export default mutations;



