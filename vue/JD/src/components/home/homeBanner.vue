<template>
	<div class="home_ban">
		<div class="m_banner clearfix" id="my_banner">
            <ul class="banner_box">
                    <li v-for="(item,index) in imgDatas" v-show="index==num" :key="index">
                        <img :src="item" alt="" />
                    </li> 
            </ul>
            <ul class="point_box">
                    <li v-for="(item,index) in imgDatas" :key="index" v-on:click="clickPlay(index)"></li> 
            </ul>
        </div>
	</div>
</template>
<script>
export default {
  data () {
    return {
        num:0,
        // imgDatas:[require('../../assets/images/l8.jpg'),
        //     require('../../assets/images/l1.jpg'),
        //     require('../../assets/images/l2.jpg'),
        //     require('../../assets/images/l3.jpg'),
        //     require('../../assets/images/l4.jpg')]
    }
  },
  props:['imgDatas'],//从父组件传值到子组件
    mounted:function(){   //生命周期  挂载完成
        this.play();
    },
    methods:{   //方法
        autoPlay:function(){
            this.num++;
            if(this.num == this.imgDatas.length){
                this.num = 0;
            }
        },
        play:function(){
            setInterval(this.autoPlay,2000);
        },
        clickPlay:function(index){
            alert(index);
           this.num=index;
        }  
    }
}
</script>
