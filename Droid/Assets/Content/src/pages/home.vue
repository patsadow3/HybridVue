<template>
  <div id="home">  

 <ul class="messages" v-chat-scroll>
    <li
      v-bind:class="{ 'input-message': todo.isInput, 'output-message': todo.isOutput }"
      v-for="(todo, index) in todos"
      v-bind:key="todo.id"
      v-bind:title="todo.title"
      v-on:remove="todos.splice(index, 1)"
    >{{todo.title}}</li>
  </ul>

  <input
    v-model="newTodoText"
    v-on:keyup.enter="addNewTodo"
    placeholder="Send message"
  >


<div class="main">
  <h1>Kinga :)</h1>
  <p>Some text some tesdsdxt some text.</p>
</div>
<div class="navbar">
  <a href="#home" class="active"><img class="icons" src="https://image.flaticon.com/icons/svg/733/733614.svg"></a>
  <a href="#news"><img class="icons" src="https://image.flaticon.com/icons/svg/733/733614.svg"></a>
  <a href="#contact"><img class="icons" src="https://image.flaticon.com/icons/svg/733/733614.svg"></a>
</div>
</div>
</template>

<script>
 export default {
  methods: {
    addNewTodo: function () {
      this.todos.push({
        id: this.nextTodoId++,
        title: this.newTodoText,
        isOutput: true,
        isInput: false
      })
      this.newTodoText = ''
    }
  },
    data() {
             return {
     newTodoText: '',
    todos: [
      {
        id: 1,
        title: 'Do the dishes',
        isInput: true,
        isOutput: false
      },
      {
        id: 2,
        title: 'Take out the trash',
        isInput: true,
        isOutput: false
      },
      {
        id: 3,
        title: 'Mow the lawn',
        isInput: false,
        isOutput: true
      }
    ],
    nextTodoId: 4
       };
 }
 }

</script>

<style scope>
body {
    display: block;
    margin: 8px;
}

.icons{
  width: 40px;
  height: 40px;
}
.messages{
  
    background-color: lightblue;
    width: 110px;
    height: 110px;
    overflow: scroll;
}
.input-message{
  color: red;
}

.output-message{
  color:blue;
}
.navbar {
  overflow: hidden;
  background-color: #333;
  position: fixed;
  bottom: 0;
  width: 100%;
  left: 0;
}

.navbar a {
  float: left;
  display: block;
  color: #f2f2f2;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
  font-size: 17px;
  height: 40px;
}

.navbar a:hover {
  background: #f1f1f1;
  color: black;
}

.navbar a.active {
  background-color: #4CAF50;
  color: white;
}



</style>