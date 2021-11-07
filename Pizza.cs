/* Pizza.cs
   Copyright (C) 2021 Ivan Guerreschi
This file is part of Pizza.
Author: Ivan Guerreschi <ivanguerreschi86@gmail.com>
Maintainer: Ivan Guerreschi <ivanguerreschi86@gmail.com>e
Pizza is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
Pizza is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
You should have received a copy of the GNU General Public License
along with Pizza.  If not, see <http://www.gnu.org/licenses/>. */

using System;

namespace Pizza
{
    class Pizza
    {
        String TipoFarina { get; set; } = default!;
        int GrammiFarina { get; set; }
        String TipoLievito { get; set; } = default!;
        int GrammiLievito { get; set; }
        int GrammiAcqua { get; set; }
        int GrammiSale { get; set; }
        int GrammiOlio { get; set; }
        int GrammiZucchero { get; set; }
        String Altro { get; set; } = default!;
    }
}
