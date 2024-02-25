using System;
using System.Collections.Generic;

namespace RestApi.Template.Persistenc.Context;

public partial class Job
{
    public short JobId { get; set; }

    public string JobDesc { get; set; } = null!;
}
