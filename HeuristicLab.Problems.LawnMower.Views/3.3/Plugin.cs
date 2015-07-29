﻿#region License Information
/* HeuristicLab
 * Copyright (C) 2002-2015 Heuristic and Evolutionary Algorithms Laboratory (HEAL)
 *
 * This file is part of HeuristicLab.
 *
 * HeuristicLab is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * HeuristicLab is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with HeuristicLab. If not, see <http://www.gnu.org/licenses/>.
 */
#endregion

using HeuristicLab.PluginInfrastructure;

namespace HeuristicLab.Problems.LawnMower.Views {
  [Plugin("HeuristicLab.Problems.LawnMower.Views", "Lawn mower demo problem for genetic programming (views)", "3.3.12.12751")]
  [PluginFile("HeuristicLab.Problems.LawnMower.Views-3.3.dll", PluginFileType.Assembly)]
  [PluginDependency("HeuristicLab.Core", "3.3")]
  [PluginDependency("HeuristicLab.Core.Views", "3.3")]
  [PluginDependency("HeuristicLab.Encodings.SymbolicExpressionTreeEncoding", "3.4")]
  [PluginDependency("HeuristicLab.Encodings.SymbolicExpressionTreeEncoding.Views", "3.4")]
  [PluginDependency("HeuristicLab.MainForm", "3.3")]
  [PluginDependency("HeuristicLab.Problems.LawnMower", "3.3")]
  public class HeuristicLabProblemsLawnMowerViewsPlugin : PluginBase {
  }
}