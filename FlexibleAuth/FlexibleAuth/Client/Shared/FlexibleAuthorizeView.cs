﻿using FlexibleAuth.Shared.Authorization;
using Microsoft.AspNetCore.Components;

namespace FlexibleAuth.Client.Shared;

public class FlexibleAuthorizeView : Microsoft.AspNetCore.Components.Authorization.AuthorizeView
{
    [Parameter]
    public Permissions Permissions
    {
        get
        {
            return string.IsNullOrEmpty(Policy) ? Permissions.None : PolicyNameHelper.GetPermissionsFrom(Policy);
        }
        set
        {
            Policy = PolicyNameHelper.GeneratePolicyNameFor(value);
        }
    }
}
