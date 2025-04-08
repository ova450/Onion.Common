

namespace Examples;
public class Foo1
{
    public int Id { get; set; } // Первичный ключ
}

public class Bar1
{
    public int Id { get; set; } // Первичный ключ
    public int Foo1Id { get; set; } // Внешний ключ
    public Foo1 Foo1 { get; set; } // Навигационное свойство для связи с Foo
}


