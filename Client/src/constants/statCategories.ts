import { IoIosStats } from "react-icons/io";
import { TbTargetArrow } from "react-icons/tb";
import { RiSwordLine } from "react-icons/ri";
import { IoSparklesSharp } from "react-icons/io5";
import { FaShieldHalved, FaSuperpowers } from "react-icons/fa6";
import { MdOutlinePets } from "react-icons/md";
import { GiBatteredAxe, GiPocketBow } from "react-icons/gi";
import { BsBriefcase } from "react-icons/bs";
import { createElement } from "react";

export const createStatCategories = () => [
  { key: "Base", title: "Base Stats", icon: createElement(IoIosStats) },
  { key: "Weapon", title: "Weapon", icon: createElement(GiBatteredAxe) },
  { key: "Skill", title: "Skills", icon: createElement(TbTargetArrow) },
  { key: "Combat", title: "Combat", icon: createElement(RiSwordLine) },
  { key: "Ranged", title: "Ranged", icon: createElement(GiPocketBow) },
  { key: "Magic", title: "Magic", icon: createElement(IoSparklesSharp) },
  { key: "Defense", title: "Defense", icon: createElement(FaShieldHalved) },
  { key: "Pet", title: "Pet", icon: createElement(MdOutlinePets) },
  { key: "Utility", title: "Utility", icon: createElement(FaSuperpowers) },
  { key: "Job", title: "Job", icon: createElement(BsBriefcase) },
] as const;
