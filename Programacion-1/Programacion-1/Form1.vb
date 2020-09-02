Public Class Form1

    Dim objdireccion = New direcciones()

    'llenar el combobox al iniciar el programa, departamentos
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cobdepartamento.Items.AddRange(objdireccion.departamento)
    End Sub

    'llenar el combobox municipio segun el departamento
    Private Sub cobdepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cobdepartamento.SelectedIndexChanged
        cobmunicipio.Items.Clear()
        cobmunicipio.Text = ""
        'llenar los municipios segun la posicion del combobox departamento
        cobmunicipio.Items.AddRange(objdireccion.municipio(cobdepartamento.SelectedIndex))

    End Sub




End Class


Class direcciones

    Public departamento() As String = {"Selecione un departamento", "Ahuachapán", "Cabañas", "Chalatenango", "Cuscatlán", "Morazán", "La Libertad", "La Paz", "La Unión", "San Miguel", "San Salvador", "San Vicente", "Santa Ana", "Sonsonate", "Usulután"}
    Public municipio()() As String = {
        New String() {"Selecione un municipio"},
        New String() {"Ahuachapán", "Apaneca", "Atiquizaya", "Concepción de Ataco", "El Refugio", "Guaymango", "Jujutla", "San Francisco Menéndez", "San Lorenzo", "San Pedro Puxtla", "Tacuba", "Turín"},     '>ahuachapan
        New String() {"Cinquera", "Villa Dolores", "Guacotecti", "Ilobasco", "Jutiapa", "San Isidro", "Sensuntepeque", "Tejutepeque", "Victoria"},                                                             '>Cabañas
        New String() {"Agua Caliente", "Arcatao", "Azacualpa", "Chalatenango", "Citalá", "Comalapa", "Concepción Quezaltepeque", "Dulce Nombre de María", "El Carrizal", "El Paraíso", "La Laguna", "La Palma", "La Reina", "Las Vueltas", "Nombre de Jesús", "Nueva Concepción", "Nueva Trinidad", "Ojos de Agua", "Potonico", "San Antonio de la Cruz", "San Antonio Los Ranchos", "San Fernando", "San Francisco Lempa", "San Francisco Morazán", "San Ignacio", "San Isidro Labrador", "San José Cancasque", "San José Las Flores", "San Luis del Carmen", "San Miguel de Mercedes", "San Rafael", "Santa Rita", "Tejutla"}, '>Chalatenango
        New String() {"Candelaria", "Cojutepeque", "El Carmen", "El Rosario", "Monte San Juano", "Oratorio de Concepción", "San Bartolomé Perulapía", "San Cristóbal", "San José Guayabal", "San Pedro Perulapán", "San Rafael Cedros", "San Ramón", "Santa Cruz Analquito", "Santa Cruz Michapa", "Suchitoto", "Tenancingo"}, '>Cuscatlán
        New String() {"Ahuachapán", "Apaneca", "Atiquizaya", "Concepción de Ataco", "El Refugio", "	Guaymango", "	Jujutla", "San Francisco Menéndez", "San Lorenzo", "San Pedro Puxtla", "Tacuba", "Turín"}, '>Morazán
        New String() {"Ahuachapán", "Apaneca", "Atiquizaya", "Concepción de Ataco", "El Refugio", "	Guaymango", "	Jujutla", "San Francisco Menéndez", "San Lorenzo", "San Pedro Puxtla", "Tacuba", "Turín"}, '>La Libertad
        New String() {"Ahuachapán", "Apaneca", "Atiquizaya", "Concepción de Ataco", "El Refugio", "	Guaymango", "	Jujutla", "San Francisco Menéndez", "San Lorenzo", "San Pedro Puxtla", "Tacuba", "Turín"}, '>La Paz
        New String() {"Ahuachapán", "Apaneca", "Atiquizaya", "Concepción de Ataco", "El Refugio", "	Guaymango", "	Jujutla", "San Francisco Menéndez", "San Lorenzo", "San Pedro Puxtla", "Tacuba", "Turín"}, '>La Unión
        New String() {"Ahuachapán", "Apaneca", "Atiquizaya", "Concepción de Ataco", "El Refugio", "	Guaymango", "	Jujutla", "San Francisco Menéndez", "San Lorenzo", "San Pedro Puxtla", "Tacuba", "Turín"}, '>San Miguel
        New String() {"Ahuachapán", "Apaneca", "Atiquizaya", "Concepción de Ataco", "El Refugio", "	Guaymango", "	Jujutla", "San Francisco Menéndez", "San Lorenzo", "San Pedro Puxtla", "Tacuba", "Turín"}, '>San Salvador
        New String() {"Ahuachapán", "Apaneca", "Atiquizaya", "Concepción de Ataco", "El Refugio", "	Guaymango", "	Jujutla", "San Francisco Menéndez", "San Lorenzo", "San Pedro Puxtla", "Tacuba", "Turín"}, '>San Vicente
        New String() {"Ahuachapán", "Apaneca", "Atiquizaya", "Concepción de Ataco", "El Refugio", "	Guaymango", "	Jujutla", "San Francisco Menéndez", "San Lorenzo", "San Pedro Puxtla", "Tacuba", "Turín"}, '>Santa Ana
        New String() {"Ahuachapán", "Apaneca", "Atiquizaya", "Concepción de Ataco", "El Refugio", "	Guaymango", "	Jujutla", "San Francisco Menéndez", "San Lorenzo", "San Pedro Puxtla", "Tacuba", "Turín"}, '>Sonsonate
        New String() {"Ahuachapán", "Apaneca", "Atiquizaya", "Concepción de Ataco", "El Refugio", "	Guaymango", "	Jujutla", "San Francisco Menéndez", "San Lorenzo", "San Pedro Puxtla", "Tacuba", "Turín"}  '>Usulután
      }
End Class