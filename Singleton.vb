''' <summary>
''' A classe Singleton define o método "GetInstance()"
''' que serve como uma altenativa para ao construtor
''' e permite que os clientes acessem a mesma instância
''' dessa classe quantas vezes quiser.
''' </summary>
Public Class Singleton
    'Variável criada apenas para mostrar que
    'sempre haverá apenas 1 instância.
    Private Shared Dim numberOfInstances = 0
    
    'A instância do Singleton é armazenada em
    'uma variável shared. Existem multiplas
    'maneiras de inicializar ela, e todas elas
    'possuem prós e contras. Nesse exemplo, nós
    'vamos mostrar a maneira mais simples, que,
    'entretanto, não funciona realmente bem em
    'programas de multithreads.
    Private Shared Dim _instance As Singleton

    'O Construtor do Singleton deve sempre ser
    'privado para prevenir chamadas de construções
    'diretas através do operador "New".
    Private Sub Singleton()
    End Sub

    'Esse é o método estático que controla o
    'acesso à instância do Sigleton. Na primeira
    'execução, é criado um objeto singleton e o
    'coloca em uma variável estática. Em execuções
    'subsequentes, ele retorna o objeto do cliente
    'armazenado na variável estática.
    Public Shared Function GetInstance() As Singleton
        
        If _instance Is Nothing
            _instance = New Singleton()
            numberOfInstances+=1
        End If
        
        SomeAction()

        Return _instance

    End Function

    'Finalmente, todos os singletons devem definir
    'alguma ação, na qual pode ser executada nessa
    'instância.
    Public Shared Sub SomeAction()
        Console.WriteLine("Acabamos de tentar Instânciar a Classe Singleton!")
        System.Threading.Thread.Sleep(750)
        Console.WriteLine("Número de Instâncias: " + numberOfInstances.ToString())
        System.Threading.Thread.Sleep(750)
    End Sub

End Class
