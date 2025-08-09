using System;
using System.Collections.Generic;

namespace ConectDatabase;

public partial class Anime
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public DateTime DataLancamento { get; set; }
}
