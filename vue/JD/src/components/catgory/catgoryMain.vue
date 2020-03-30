<template>
    <div class="category_content">
      <CatgoryMainLeft/>
      <CatgoryMainRight/>
    </div>
</template>
<script>
import CatgoryMainLeft from './catgoryMainLeft'
import CatgoryMainRight from './catgoryMainRight'
export default {
    data(){
        return{
            msg:'搜索页面Main'
        }
    },
    components:{
        CatgoryMainLeft,
        CatgoryMainRight
    }
}
</script>
