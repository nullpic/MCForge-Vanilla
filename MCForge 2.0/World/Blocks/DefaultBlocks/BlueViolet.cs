﻿/*
Copyright 2011 MCForge
Dual-licensed under the Educational Community License, Version 2.0 and
the GNU General Public License, Version 3 (the "Licenses"); you may
not use this file except in compliance with the Licenses. You may
obtain a copy of the Licenses at
http://www.opensource.org/licenses/ecl2.php
http://www.gnu.org/licenses/gpl-3.0.html
Unless required by applicable law or agreed to in writing,
software distributed under the Licenses are distributed on an "AS IS"
BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
or implied. See the Licenses for the specific language governing
permissions and limitations under the Licenses.
*/

namespace MCForge.World.Blocks
{
    public class BlueViolet : Block
    {
        public override string Name
        {
            get { return "blueviolet"; }
        }
        public override byte VisibleBlock
        {
            get { return 29; }
        }
        public override byte Permission
        {
            get { return 0; }
        }
    }
}
