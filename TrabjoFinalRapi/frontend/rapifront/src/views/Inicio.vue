<template>
<html lang="en">
<head>
</head>
<body>

<nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <a class="navbar-brand" href="http://localhost:8080/Inicio">RapiSolver</a>
  <ul class="navbar-nav">
    <li class="nav-item">
      <a class="nav-link" href="http://localhost:8080/Inicio">Inicio Sesion</a>
    </li>
    <li class="nav-item">
      <a class="nav-link" href="#">¿Quienes somos?</a>
    </li>
  </ul>
</nav>

<div class="p-3">
            <img class="img-fluid rounded-circle" src="../assets/Logo.jpg" id="ImagenLogo" >
</div>

<form id="formulario">
		<div class="form-group" >
			<label for="exampleInputEmail1">Email address</label> 
			<input type="email" class="form-control col-lg-3 col-md-3 col-xs-12" id="exampleInputEmail1" aria-describedby="emailHelp"
				placeholder="Enter email" v-model="logeo.userName"> <small id="emailHelp"
				class="form-text text-muted">We'll never share your email
				with anyone else.</small>
		</div>
		<div class="form-group">
			<label for="exampleInputPassword1">Password</label> <input
				type="password" class="form-control col-lg-3 col-md-3 col-xs-12"
				id="exampleInputPassword1" placeholder="Password" v-model="logeo.userPassword">	
		</div>

		<button type="submit" class="btn btn-primary" v-on:click.prevent="post" >Ingresar</button>
		<br>
		<br>
		<a class="btn btn-secondary" href="http://localhost:8080/agregarUsuario">Registrarse</a>

		
</form>



</body>
</html>

</template>

<script>
import axios from 'axios'
export default {
data(){
	return{
            logeo:{
                 userName: "",
                 userPassword: ""
			},
			usuarios:null

        }
	},
	mounted(){
		this.getUsuarios();
    },
    methods:{
        getUsuarios(){
            axios.
                get('https://localhost:5001/api/Usuario')
                    .then(response=>{
                        this.usuarios=response.data
                    })
                    .catch(e=>console.log(e))
		},
		post:function(){
		var name=this.logeo.userName;
		var contraseña=this.logeo.userPassword;
        this.usuarios.forEach(function(element) {
			
             if ((element.userName == name)&& (element.userPassword == contraseña)) {window.location.href="http://localhost:8080/Principal" }	   
         });
		}
    }
}
</script>

<style>
#formulario {
	position: relative !important;
	left: 30% !important;
}

#ImagenLogo{
	width:400px;
    height:250px;
    border-radius:150px;
    position: relative !important;
	left: 30% !important;
    
}

</style>