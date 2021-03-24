Module Module1

    Sub Main()
        'Tentativas de multiplas instâncias para mostrar
        'que não é possível quando utilizamos o singleton.
        Dim s1 As Singleton = Singleton.GetInstance()
        Dim s2 As Singleton = Singleton.GetInstance()
        Dim s3 As Singleton = Singleton.GetInstance()
        Dim s4 As Singleton = Singleton.GetInstance()

        Console.WriteLine(vbNewLine + "Ou seja, quando usamos o Singleton, não importa quantas " +
                          vbNewLine + "vezes tentemos, teremos apenas uma instância do objeto!") 
        
        Console.ReadLine()
    End Sub

End Module
