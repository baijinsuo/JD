<template>
    <div>
        <h2>{{msg}}</h2>
         <h3>{{$store.state.count}}</h3>
        <h1>{{$store.state.name}}</h1>
        <h1>{{$store.state.name1}}</h1>
        <h1>{{$store.state.name2}}</h1>
        <h1>{{$store.state.name3}}</h1>
        <h1>{{$store.state.name4}}</h1>
        <button @click="$store.commit('add')">点击</button><br><br>
          <button @click="add">点击dispach加1</button><br><br>
          <button @click="remove">点击dispach减1（大于3的时候才可以执行）</button><br><br>
<h1>计算属性的值{{count}}</h1>

    </div>
</template>


<script>
import {mapGetters,mapActions} from 'vuex'
export default {
    data(){
        return{
            msg:'发现页面'
        }
    },
    computed:mapGetters(['count']),
    methods:{
        ...mapActions(['add','remove']),
        // add(){
        //     this.$store.dispatch('add');
        // },
        // remove(){
        //     this.$store.dispatch('remove')
        // }
    }
}
</script>
