﻿using ADOPSE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADOPSE.Services.IServices;

public interface IModuleService
{
    IEnumerable<Module> GetModules();

    Module GetModuleById(int id);

    IActionResult GetModuleStacks(int limit, int offset);

    IActionResult GetModuleStacksByLecturerId(int limit, int offset, int id);

    IActionResult GetFilteredModules(Dictionary<string, string> dic, int limit, int offset);

    Module GetModuleByCalendarId(string id);

    public void CreateIndex();

}