<template>
    
  <div class="restaurant--row">
    <h2 class="title">
        Nos restaurants
    </h2>
    <div class="wrapper--card">
        <RestaurantCard v-for="(card,index) in threeRestaurants" :key="index" :infoRestau="card"/>
    </div>
  </div>
</template>

<script>
import RestaurantCard from "../components/RestaurantCard.vue";

export default {
    name:"RestaurantRow",
  components: {
    RestaurantCard, // Incluez le composant enfant ici
  },
  props:{
    threeRestaurants:Array
  }
};
</script>

<style lang='scss'>
    .restaurant--row{
        .wrapper--card{
            display: flex;
            align-items: center;
            justify-content: space-between;
            
        }
    }
</style>