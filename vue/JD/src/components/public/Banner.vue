<template>
	<div class="home_ban">
         <ul class="banner_child_box">
            <li class="banner_item" v-for="(item,i) in imgDatas" :key="i" v-show="i==num">
                <img :src="item.imageUrl" alt="" class="banner_pic">
            </li>
         </ul>
            <div class="banner_count">
                <em id="slide-nub" class="fz18">{{num+1}}</em>
                <em class="nub-bg">/</em>
                <em id="slide-sum" class="fz12">{{imgDatas.length}}</em>
          </div>
	</div>
</template>
<script>
export default {
  data () {
    return {
        num:0,
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
