<template>
<html lang="en">
<head>
</head>
<body>

<nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <a class="navbar-brand" href="#">RapiSolver</a>
  <ul class="navbar-nav">
    <li class="nav-item">
      <a class="nav-link" href="#">Inicio Sesion</a>
    </li>
    <li class="nav-item">
      <a class="nav-link" href="#">¿Quienes somos?</a>
    </li>
  </ul>
</nav>

    <div id="labelCrearUsuario"><h2>Registro de Usuario</h2></div><br>
	<form id="formulario" >
		<div class="form-group" >
			<label >Nombre:</label> <input type="text" class="form-control col-lg-3 col-md-3 col-xs-12" placeholder="Ingrese Nombres" v-model="usuario.name"> 
		</div>
		<div class="form-group" >
			<label >Apellido:</label> <input type="text" class="form-control col-lg-3 col-md-3 col-xs-12" placeholder="Ingrese Apellidos" v-model="usuario.lastName">  
		</div>
		<div class="form-group" >
			<label >Email:</label> <input type="text" class="form-control col-lg-3 col-md-3 col-xs-12" placeholder="Ingrese un email" v-model="usuario.email"> 
		</div>
        <div class="form-group" >
			<label >Contraseña::</label> <input type="password" class="form-control col-lg-3 col-md-3 col-xs-12" placeholder="Ingrese una contraseña" v-model="usuario.contraseña"> 
		</div>
		<div class="form-group" >
			<label >Telefono:</label> <input type="text" class="form-control col-lg-3 col-md-3 col-xs-12" placeholder="Ingrese un telefono" v-model="usuario.phone"> 
		</div>
        <div class="form-group" >
			<label >Edad:</label> <input type="text" class="form-control col-lg-3 col-md-3 col-xs-12" placeholder="Ingrese su edad" v-model="usuario.age"> 
		</div>
       <div class="form-group" >
			<label >Sexo:</label><br>
           <select class="browser-default custom-select form-control col-lg-3 col-md-3 col-xs-12" v-model="usuario.genger">
                <option selected>Seleccion el sexo</option>
                <option value="Masculino">Masculino</option>
                <option value="Femenino">Femenino</option>
                <option value="Ambos">Ambos</option>
            </select>
		</div>
        <div class="form-group" >
			<label >Pais:</label><br>
           <select class="browser-default custom-select form-control col-lg-3 col-md-3 col-xs-12" v-model="usuario.country">
                <option selected>Seleccion el Pais</option>
                <option value="Perú">Perú</option>
            </select>
		</div>
           <div class="form-group" >
			<label >Departamento:</label><br>
           <select class="browser-default custom-select form-control col-lg-3 col-md-3 col-xs-12" v-model="usuario.state">
                <option selected>Seleccion el Departamento</option>
                <option value="Lima">Lima</option>
            </select>
		</div>
        <div class="form-group" >
			<label >Distrito:</label><br>
           <select class="browser-default custom-select form-control col-lg-3 col-md-3 col-xs-12" v-model="usuario.city">
                <option selected>Seleccion el Distrito</option>
                <option value="Lima">Lima</option>
            </select>
		</div>
         <div class="form-group" >
			<label >Direccion:</label> <input type="text" class="form-control col-lg-3 col-md-3 col-xs-12" placeholder="Ingrese su direccion" v-model="usuario.address"> 
		</div>

        <button v-on:click.prevent="post" class="btn btn-primary">Agregar</button>
	</form>




</body>
</html>
</template>

<script>
export default {
    data(){
        return{
            usuario:{
                 name: "",
                 lastName: "",
                 email: "",
                 phone: "",
                 age: "",
                 genger: "",
                 country: "",
                 state: "",
                 city: "",
                 address: "",
                 contraseña:""
            }

        }
    },
    methods:{
        post:function(){
            this.$http.post('https://localhost:5001/api/Customer',{
                 name: this.usuario.name,
                 lastName: this.usuario.lastName,
                 email: this.usuario.email,
                 phone: this.usuario.phone,
                 age: this.usuario.age,
                 genger: this.usuario.genger,
                 country: this.usuario.country,
                 state: this.usuario.state,
                 city: this.usuario.city,
                 address: this.usuario.address,
                 contraseña:this.usuario.contraseña

            }).then(function(data){
                alert ("Se ha registrado con exito.");
                console.log(data);
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
#labelCrearUsuario{
	position: relative !important;
	left: 30% !important;
}

</style>