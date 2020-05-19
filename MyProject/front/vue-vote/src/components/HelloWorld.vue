<template>
  <div class="hello">
    <p v-on:click="getLists()">{{mess}}</p>
    {{getLists()}}
  </div>
</template>

<script>
export default {
  
  data () {
    return {
      mess: "zxc"
    }
  },
  methods:{
    getLists: async function(){
      const response = await fetch("https://localhost:44315/api/TodoItems");
      this.mess = await response.json();
    }
  }
}
</script>>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>