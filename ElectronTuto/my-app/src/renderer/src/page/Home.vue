<template>
    <div class="home">
        <RestaurantRow v-for="(data, i) in restaurants" :key="i" :threeRestaurants="data"/>
    </div>
  
</template>

<script type="module">
    import BDD from "../BDD.ts";
    import {onMounted, ref} from 'vue';
    import {Restaurant} from "../class/Restaurant.ts";
    import RestaurantRow from "../components/RestaurantRow.vue";

    export default {
        name:"Home",
        components:{
            RestaurantRow,
        },
        setup(){
            let restaurants = ref([]);
            const makeDataRestaurant = () =>{
                let threeRestaurants =[];
                for(let restau of BDD.info){
                    threeRestaurants.push(new Restaurant(restau.name,restau.note,restau.image,restau.drive_time));
                    if(threeRestaurants.length==3){
                        restaurants.value.push(threeRestaurants);
                        threeRestaurants=[];
                    }
                }
                if(threeRestaurants.length>0){
                    restaurants.push(threeRestaurants);
                    threeRestaurants=[];
                }
            }
            onMounted(makeDataRestaurant);

            return {
                restaurants
            }
        }
    }


</script>

<style>

</style>