﻿using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace TabBlazor.Components
{
    public partial class Checkbox : ComponentBase
    {
        [Parameter] public string Label { get; set; }
        [Parameter] public string Description { get; set; }
        [Parameter] public bool Value { get; set; }
        [Parameter] public EventCallback<bool> ValueChanged { get; set; }
        [Parameter] public bool Disabled { get; set; }

          protected async Task ToggleState() {
            Value = !Value;
            await ValueChanged.InvokeAsync(Value);
        }
    }
}
