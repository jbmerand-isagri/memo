﻿using Ardalis.Result;

namespace Memo.UseCases.Contributors.Create;

/// <summary>
/// Create a new Contributor.
/// </summary>
/// <param name="Name"></param>
public record CreateContributorCommand(string Name) : Ardalis.SharedKernel.ICommand<Result<int>>;
