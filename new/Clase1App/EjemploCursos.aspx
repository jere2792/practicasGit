﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploCursos.aspx.cs" Inherits="Clase1App.EjemploCursos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEAg3QhqLMpG8r+8fhAXLRk2vvoC2f3B09zVXn8CA5QIVfZOJ3BCsw2P0p/We" crossorigin="anonymous" />
    <title>Ejemplo cursos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Ejemplo de Curso</h1>
            <h4>Listado de Estudiantes</h4>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>DNI</th>
                        <th>Nombre</th>
                        <th>Apellido</th>
                    </tr>
                </thead>
                <tbody>
                    <%foreach (Clase1App.Estudiante estudiante in MiCurso.Estudiantes)
                        { %>
                    <tr>
                        <td><%= estudiante.Dni %></td>
                        <td><%= estudiante.Nombre %></td>
                        <td><%= estudiante.Apellido %></td>
                    </tr>
                    <% } %>
                </tbody>
            </table>
            <h4>Datos del Instructor/a</h4>
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>DNI</th>
                        <th>Nombre</th>
                        <th>Apellido</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td><%= MiCurso.Instructor.Dni %></td>
                        <td><%= MiCurso.Instructor.Nombre %></td>
                        <td><%= MiCurso.Instructor.Apellido %></td>
                    </tr>
                </tbody>
            </table>
            <h4>Materias asignadas a la Instructor/a</h4>
            <table class="table table-hover table-bordered">
                <thead>
                    <tr>
                        <th>Nombre</th>
                        <th>Programa</th>
                    </tr>
                </thead>
                <tbody>
                    <% foreach (Clase1App.Materia materia in MiCurso.Instructor.Materias)
                        { %>
                       <tr>
                           <td><%= materia.Nombre %></td>
                           <td><%= materia.Programa %></td>
                       </tr> 
                    <%} %>
                </tbody>
            </table>
            <h4>Listado de clases del Curso</h4>
            <table class="table table-primary table-bordered">
                <thead>
                    <tr>
                        <th>Inicio</th>
                        <th>Fin</th>
                        <th>Aula</th>
                    </tr>
                </thead>
                <tbody>
                    <% foreach (Clase1App.Clase clase in MiCurso.Clases)
                        { %>
                        <tr>
                            <td><%= clase.Inicio.ToString("dd/MM/yyyy HH:mm") %> hs</td>
                            <td><%= clase.Fin.ToString("dd/MM/yyyy HH:mm") %> hs</td>
                            <td><%= clase.Aula.Codigo %></td>
                        </tr>
                    <% } %>
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>
