<template>
   <html lang="en">
<head>
</head>
<body>

    <nav class="navbar navbar-expand-sm bg-dark navbar-dark">
    <a class="navbar-brand" href="#">RapiSolver</a>
  <ul class="navbar-nav">
    <li class="nav-item">
      <a class="nav-link" href="#">Mi perfil</a>
    </li>
    <li class="nav-item">
      <a class="nav-link" href="#">Publicar Servicio</a>
    </li>
     <li class="nav-item">
      <a class="nav-link" href="#">Buscar Servicio</a>
    </li>
     <li class="nav-item">
      <a class="nav-link" href="#">Buscar Personas</a>
    </li>
  </ul>
</nav>

<br/>
<br/>


	<div class="container">
		<div class="card">
			<div class="card-header text-white bg-secondary">Buscar Servicios</div>
			<div class="card-body">
                <div class="form-inline">
					<form >
						<div class="row">
							<div class="col-8">
								<input id="inputServicioNombre" type="text"
								class="form-control" name="servicioNombre"
								placeholder="Buscar por nombre">
							</div>
							<div class="col">
								<button type="submit" class="btn btn-danger">Buscar</button>
							</div>
						</div>
					</form>
                </div>	
			</div>
				<div class="table responsive">
					<table class="table table-striped">
						<thead class="thead-dark">
							<tr>
								<th>Id</th>
								<th>Nombre</th>
								<th>Categoria</th>
								<th>Cost</th>
								<th>Detalle</th>								
							</tr>
						</thead>
						<tbody>
							<tr v-for="detalle in detalles" :key="detalle.serviceDetailsId">
								<td >{{detalle.serviceDetailsId}}</td>
								<td >{{detalle.serviceName}}</td>
								<td >{{detalle.categoryName}}</td>
								<td >{{detalle.cost}}</td>
								<td><a href="" class="btn btn-success">Detalle</a>
								</td>								
							</tr>
						</tbody>
					</table>
				</div>
			</div>
		</div>
	
</body>
</html>
</template>

<script>
import axios from 'axios'
export default {
    data(){
        return{
            detalles:null
        }
    },
    mounted(){
        this.getDetalles();
    },
    methods:{
        getDetalles(){
            axios.
                get('https://localhost:5001/api/ServiceDetails')
                    .then(response=>{
                        this.detalles=response.data
                    })
                    .catch(e=>console.log(e))
        }
    }

}
</script>

<style>

</style>