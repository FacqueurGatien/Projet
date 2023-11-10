<template>
    <div class="restaurant--card">
        <div :style="ChangeBackground" class="restaurant--image">
            
        </div>
        <div class="restaurant--informations">
            <div class="top">
                <p class="name">
                    {{infoRestau.getName()}}
                </p>
                <p class="note">
                    <span>
                        {{infoRestau.getNote()}}
                    </span>
                </p>
            </div>
            <p class="time">
                {{infoRestau.getDriveTime()}}
            </p>
        </div>
    </div>
</template>

<script>
import {Restaurant} from "../class/Restaurant.ts";
import {computed} from 'vue';
export default{
  name: "restaurantCard",
  props:{
    infoRestau:Object
  },
  setup(props){
    const ChangeBackground = computed(()=>{
        return{
            backgroundImage:`url(${"src/img/"+props.infoRestau.image})`
        };
    });
    return{
        ChangeBackground
    }
  }
}
</script>

<style lang="scss">
:root {
  --image-url: none; /* Définissez la valeur par défaut à "none" */
}
.restaurant--card {
  width: 32%;
  height: 30vh;
  p {
    margin: 0;
    color: salmon;
  }
  .restaurant--image {
    background-size: cover;
    background-position: center;
    height: 70%;
  }
}
.restaurant--informations{
    .top{
        margin: 10px 0px;
        display: flex;
        align-items: center;
        justify-content: space-between;
        .note{
            background-color: #eeeeee;
            height: 30px;
            width: 30px;
            display: flex;
            justify-content: center;
            align-items: center;
            font-size: 0.8rem;
            border-radius: 50%;
        }
    }
    .time{
        font-size: 0.9rem;
    }
}
</style>