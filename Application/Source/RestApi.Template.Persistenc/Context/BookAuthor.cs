﻿using System;
using System.Collections.Generic;

namespace RestApi.Template.Persistenc.Context;

public partial class BookAuthor
{
    public int AuthorId { get; set; }

    public int BookId { get; set; }

    public byte? AuthorOrder { get; set; }

    public int? RoyalityPercentage { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual Book Book { get; set; } = null!;
}
