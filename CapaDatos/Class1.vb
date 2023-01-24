Imports System.Data.SqlClient
Public Class Class1
    Public Shared Function Mostrar() As DataTable
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using da As New SqlDataAdapter("select * from usuario", cn)
                Using tabla As New DataTable
                    da.Fill(tabla)

                    Return tabla
                End Using
            End Using
        End Using
    End Function

    Public Shared Function MostrarIdCita(fecha As String, hora As String) As DataTable
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using da As New SqlDataAdapter("select c.id_cita from cita as c inner join cita_hora as ch on c.id_cita = ch.id_cita_hora where c.fecha= '" + fecha + "' and ch.hora = '" + hora + "'", cn)
                Using tabla As New DataTable
                    da.Fill(tabla)

                    Return tabla
                End Using
            End Using
        End Using
    End Function

    Public Shared Sub registrarCita(id_cita As String, id_usuario As String, hora As String)
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using insert As New SqlCommand("insert into registro (id_cita_registro, id_usuario_registro,hora)values(" + id_cita + "," + id_usuario + ",'" + hora + "')", cn)
                cn.Open()
                insert.ExecuteNonQuery()
                cn.Close()
            End Using
        End Using
    End Sub

    Public Shared Function ConsultarFecha(servicio As String) As DataTable
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using da As New SqlDataAdapter("select fecha from cita where servicio ='" + servicio + "'", cn)
                Using tabla As New DataTable
                    da.Fill(tabla)

                    Return tabla
                End Using
            End Using
        End Using
    End Function

    Public Shared Function ConsultarHora(fecha As String, servicio As String) As DataTable
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using da As New SqlDataAdapter("select c.fecha, ch.hora from cita as c inner join cita_hora as ch on c.id_cita = ch.id_cita_hora where c.fecha= '" + fecha + "' and c.servicio='" + servicio + "'", cn)
                Using tabla As New DataTable
                    da.Fill(tabla)

                    Return tabla
                End Using
            End Using
        End Using
    End Function

    Public Shared Function ConsultarTodo(id As String) As DataTable
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using da As New SqlDataAdapter("Select c.servicio, c.fecha, r.hora, r.descripcion_doctor from registro as r inner join cita as c on r.id_cita_registro = c.id_cita where r.id_usuario_registro='" + id + "'", cn)
                Using tabla As New DataTable
                    da.Fill(tabla)

                    Return tabla
                End Using
            End Using
        End Using
    End Function
    Public Shared Function ConsultarServicio(id As String, servicio As String) As DataTable
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using da As New SqlDataAdapter("Select c.servicio, c.fecha, r.hora, r.descripcion_doctor from registro as r inner join cita as c on r.id_cita_registro = c.id_cita where r.id_usuario_registro='" + id + "' and c.servicio='" + servicio + "'", cn)
                Using tabla As New DataTable
                    da.Fill(tabla)

                    Return tabla
                End Using
            End Using
        End Using
    End Function

    Public Shared Function CitaRapida(s As String, f As String) As DataTable
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using insert As New SqlCommand("insert into cita (servicio, fecha)values('" + s + "','" + f + "')", cn)
                cn.Open()
                insert.ExecuteNonQuery()
                cn.Close()
                Using da As New SqlDataAdapter("select max(id_cita) as id_cita from cita", cn)
                    Using tabla As New DataTable
                        da.Fill(tabla)

                        Return tabla
                    End Using
                End Using
            End Using
        End Using
    End Function

    Public Shared Sub CitaRapida2(idservicio As String, id As String, hora As String, descripcion As String)
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using insert As New SqlCommand("insert into registro (id_cita_registro, id_usuario_registro,hora,descripcion_paciente)values(" + idservicio + "," + id + ",'" + hora + "','" + descripcion + "')", cn)
                cn.Open()
                insert.ExecuteNonQuery()
                cn.Close()
            End Using
        End Using
    End Sub


    Public Shared Function Login(u As String, c As String) As DataTable
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using da As New SqlDataAdapter("select * from usuario where correo='" + u + "'and password='" + c + "'", cn)
                Using tabla As New DataTable
                    da.Fill(tabla)

                    Return tabla
                End Using
            End Using
        End Using
    End Function

    Public Shared Sub Registro(nombre As String, apellido As String, cedula As String, correo As String, contrasena As String)
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using insert As New SqlCommand("insert into usuario (nombre, apellido,cedula,correo ,password)values('" + nombre + "','" + apellido + "','" + cedula + "','" + correo + "','" + contrasena + "')", cn)
                cn.Open()
                insert.ExecuteNonQuery()
                cn.Close()
            End Using
        End Using
    End Sub

    Public Shared Sub ACTUALIZARUSUARIO(nombre As String, apellido As String, pass As String, id As String)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("UPDATE usuario
                                         SET nombre = '" + nombre + "', apellido= '" + apellido + "',password = '" + pass + "'
                                         WHERE id_usuario = " + id, CN)
                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Shared Function LISTARCITAS() As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)

            Using DA As New SqlDataAdapter("Sp_listar_citas", CN)
                Using TABLA As New DataTable
                    DA.Fill(TABLA)

                    Return TABLA
                End Using


            End Using
        End Using

    End Function

    Public Shared Function verInfo(id As String) As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("select nombre, apellido, password from usuario where id_usuario=" + id, CN)
                Using TABLA As New DataTable
                    DA.Fill(TABLA)

                    Return TABLA
                End Using
            End Using
        End Using

    End Function


    Public Shared Function allSolicitudes() As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("select c.servicio,r.hora, c.fecha from registro as r inner join cita as c on r.id_cita_registro = c.id_cita group by r.hora, c.servicio, c.fecha", CN)
                Using TABLA As New DataTable
                    DA.Fill(TABLA)

                    Return TABLA
                End Using
            End Using
        End Using

    End Function

    Public Shared Function ConsultarUsuario() As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("select distinct u.correo from registro as r inner join usuario as u on r.id_usuario_registro = u.id_usuario ", CN)
                Using TABLA As New DataTable
                    DA.Fill(TABLA)

                    Return TABLA
                End Using
            End Using
        End Using
    End Function

    Public Shared Function ConsultarCitasPaciente(correo As String, fecha As String) As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("select c.servicio from cita as c inner join registro as r on c.id_cita=r.id_cita_registro inner join usuario as u on r.id_usuario_registro=u.id_usuario where correo='" + correo + "' and c.fecha = '" + fecha + "'", CN)
                Using TABLA As New DataTable
                    DA.Fill(TABLA)

                    Return TABLA
                End Using
            End Using
        End Using
    End Function

    Public Shared Function ConsultarIdRegistro(correo As String, fecha As String, servicio As String) As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("select r.id_registro from cita as c inner join registro as r on c.id_cita=r.id_cita_registro inner join usuario as u on r.id_usuario_registro=u.id_usuario where correo='" + correo + "' and c.fecha = '" + fecha + "' and c.servicio='" + servicio + "'", CN)
                Using TABLA As New DataTable
                    DA.Fill(TABLA)

                    Return TABLA
                End Using
            End Using
        End Using
    End Function

    Public Shared Function verInfoUser(correo As String) As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("select correo,password,tipo_usuario from usuario where correo='" + correo + "'", CN)
                Using TABLA As New DataTable
                    DA.Fill(TABLA)

                    Return TABLA
                End Using
            End Using
        End Using
    End Function

    Public Shared Function verInfoUserCorreo() As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("select correo from usuario ", CN)
                Using TABLA As New DataTable
                    DA.Fill(TABLA)

                    Return TABLA
                End Using
            End Using
        End Using
    End Function

    Public Shared Sub updateUserAdmin(correo As String, pass As String, tipo As String, correoViejo As String)
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using insert As New SqlCommand("update usuario set correo='" + correo + "', password='" + pass + "', tipo_usuario=" + tipo + " where correo = '" + correoViejo + "'", cn)
                cn.Open()
                insert.ExecuteNonQuery()
                cn.Close()
            End Using
        End Using
    End Sub

    Public Shared Sub updateRegistro(idR As String, descripcion As String)
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using insert As New SqlCommand("update registro set descripcion_doctor='" + descripcion + "' where id_registro =" + idR, cn)
                cn.Open()
                insert.ExecuteNonQuery()
                cn.Close()
            End Using
        End Using
    End Sub

    Public Shared Sub addUser(correo As String, pass As String, tipo As String)
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using insert As New SqlCommand("insert into usuario (correo ,password,tipo_usuario) values('" + correo + "','" + pass + "'," + tipo + ")", cn)
                cn.Open()
                insert.ExecuteNonQuery()
                cn.Close()
            End Using
        End Using
    End Sub

    Public Shared Function ConsultarFechasPaciente(correo As String) As DataTable
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("select c.fecha from cita as c inner join registro as r on c.id_cita=r.id_cita_registro inner join usuario as u on r.id_usuario_registro=u.id_usuario where correo='" + correo + "'", CN)
                Using TABLA As New DataTable
                    DA.Fill(TABLA)

                    Return TABLA
                End Using
            End Using
        End Using
    End Function

    Public Shared Sub horaCita(id_cita As String, hora As String)
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using insert As New SqlCommand("insert into cita_hora (id_cita_hora, hora)values(" + id_cita + ",'" + hora + "')", cn)
                cn.Open()
                insert.ExecuteNonQuery()
                cn.Close()
            End Using
        End Using
    End Sub

    Public Shared Function cronograma(s As String, f As String) As DataTable
        Using cn As New SqlConnection(My.Settings.Conexion)
            Using insert As New SqlCommand("insert into cita (servicio, fecha)values('" + s + "','" + f + "')", cn)
                cn.Open()
                insert.ExecuteNonQuery()
                cn.Close()
                Using da As New SqlDataAdapter("select max(id_cita) as id_cita from cita", cn)
                    Using tabla As New DataTable
                        da.Fill(tabla)

                        Return tabla
                    End Using
                End Using
            End Using
        End Using
    End Function

End Class

