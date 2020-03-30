<template>
    <div>
    <div>
        <!-- 搜索区域 -->
        <homeSearch/>
    </div>


    <div>
        <!-- 轮播区域 -->
        <homeBanner v-bind:imgDatas="imgArry"/>
    </div>

    <div>
        <!-- 导航区域 -->
        <homeNav/>
    </div>


    <div>
        <!-- 展示区域 缓存商品列表-->
    <keep-alive include="homeContent">
        <homeContent/>
    </keep-alive>

        <!-- <homeContent/> -->
    </div>
    </div>
</template>

<script>
//导入头部搜索区域
import homeSearch from './homeSearch'

//导入轮播区域
import homeBanner from './homeBanner'

//导入导航区域
import homeNav from './homeNav'

//导入内容区域
import homeContent from './homeContent'


export default {
    data(){
        return{
            msg:'主页',
            imgArry:[
                require('../../assets/images/l8.jpg'),
                require('../../assets/images/l1.jpg'),
                require('../../assets/images/l2.jpg'),
                require('../../assets/images/l3.jpg'),
                require('../../assets/images/l4.jpg')
            ]
        }
    },
    components:{
        homeSearch,
        homeBanner,
        homeNav,
        homeContent
    }
}
</script>

<style>
    /*
        导入外部样式
    */
    @import '../../assets/css/index.css';
</style>
