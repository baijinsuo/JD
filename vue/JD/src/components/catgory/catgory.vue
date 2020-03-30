<template>
    <div>
        <CatgoryHead/>
        <CatgoryMain/>
    </div>
</template>


<script>
import CatgoryHead from './catgoryHead';//导入分类头部
import CatgoryMain from './catgoryMain'; //导入分类主体
export default {
    data(){
        return{
            msg:'搜索页面'
        }
    },
    components:{
        CatgoryHead,
        CatgoryMain,
    }
}
</script>

<style> 
    @import '../../assets/css/category.css';
</style>
