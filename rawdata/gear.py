




Andartia_Critagi = {"Name":"Andartia's Mantle", Name2"":"Andartia's Mantle AGI Crit Rate", "AGI":30, "Accuracy":20, "Attack":20, "Crit Rate":10, "PDT":-10, "Jobs":["nin"]}
# Each job has identical Ambuscade cape augments. Here I define a simple code block to automatically build each possible type of ambu cape for each job.
# We define filters so that some cape variants aren't created, such as CHR capes on NIN which would never be used and would only waste computation time if included.
# This is a simple loop reading from pre-defined lists, but it will save us well over 100 lines of modifying nearly identical capes with different names and jobs.
cape_names = {
              "WAR":["Cichol's Mantle",{"DA Damage%":20, "Jobs":["war"]},["Str", "DEX", "VIT", "AGI", "INT", "MND", "CHR"]],
              "MNK":["Segomo's Mantle",{"Kick Attacks":10, "Kick Attacks DMG":25, "Jobs":["mnk"]},["Str", "DEX", "VIT", "AGI", "INT", "MND", "CHR"]],
              "WHM":["Alaunus's Cape",{"Jobs":["whm"]},["Str", "DEX", "MND"]],
              "BLM":["Taranus's Cape",{"Magic Burst Damage":5, "Jobs":["blm"]},["Str", "DEX", "INT", "MND"]],
              "RDM":["Sucellos's Cape",{"Jobs":["rdm"]},["Str", "DEX", "INT", "MND", "AGI"]],
              "THF":["Toutatis's Cape",{"Sneak Attack Bonus":10, "TA Damage%":20, "Jobs":["thf"]},["Str", "DEX", "VIT", "AGI", "INT", "MND", "CHR"]],
              "PLD":["Rudianos's Mantle",{"Jobs":["pld"]},["Str", "DEX", "INT", "AGI", "MND", "VIT",]],
              "DRK":["Ankou's Mantle",{"Jobs":["drk"]},["Str", "DEX", "VIT", "INT"]],
              "BST":["Artio's Mantle",{"Jobs":["bst"]},["Str", "DEX", "VIT", "INT", "CHR"]],
              "BRD":["Intarabus's Cape",{"Jobs":["brd"]},["Str", "DEX", "CHR", "INT", "MND"]],
              "RNG":["Belenus's Cape",{"Jobs":["rng"]},["Str", "DEX", "INT", "AGI",]],
              "SMN":["Campestres's Cape",{"Jobs":["smn"]},["Str", "DEX", "INT", "MND", "CHR"]],
              "SAM":["Smertrios's Mantle",{"Jobs":["sam"]},["Str", "DEX", "VIT", "INT", "AGI"]],
              "NIN":["Andartia's Mantle",{"Jobs":["nin"]},["Str", "DEX", "INT", "AGI"]],
              "DRG":["Brigantia's Mantle",{"Jobs":["drg"]},["Str", "DEX", "VIT", "AGI", "INT"]],
              "BLU":["Rosmerta's Cape",{"Jobs":["blu"]},["Str", "DEX", "INT", "AGI", "MND",]],
              "COR":["Camulus's Mantle",{"Triple Shot":5, "Jobs":["cor"]},["Str", "DEX", "AGI", "INT"]],
              "PUP":["Visucius's Mantle",{"Jobs":["pup"]},["Str", "DEX", "INT", "VIT",]],
              "DNC":["Senuna's Mantle",{"Crit Damage":5, "Jobs":["dnc"]},["Str", "DEX", "VIT", "AGI", "INT", "MND", "CHR"]],
              "SCH":["Lugh's Cape",{"SkillchainBonus":10, "Jobs":["sch"]},["Str", "DEX", "INT", "MND"]],
              "GEO":["Nantosuelta's Cape",{"Jobs":["geo"]},["Str", "DEX", "INT", "CHR", "MND"]],
              "RUN":["Ogma's cape",{"Jobs":["run"]},["Str", "DEX", "INT", "VIT",]],
            # Will add more capes as I add more jobs.
              }

# Now list each base stat and the main stats you want to be considered with the base stat.
ambu_stats = {"Str":["Weapon Skill Damage", "DA", "Crit Rate"],
              "DEX":["Weapon Skill Damage", "DA", "Store TP", "Dual Wield", "Crit Rate"],
              "VIT":["Weapon Skill Damage", "DA"],
              "AGI":["Weapon Skill Damage", "DA", "Store TP", "Crit Rate", "Dual Wield"],
              "INT":["Weapon Skill Damage", "DA", "Store TP"],
              "MND":["Weapon Skill Damage", "DA"],
              "CHR":["Weapon Skill Damage", "DA"]}

# I failed to write this in a single-line with list comprehension. I was close, but a multi-line for-loop is easier to read anyway...
capes = []
for job in cape_names:
    for base_stat in ambu_stats:
        if base_stat not in cape_names[job][2]:
            continue # Skip stats for jobs that don't use them. (For example: Don't consider ANY capes with CHR, MND, or VIT for NIN)
        for main_stat in ambu_stats[base_stat]:
            capes.append({**{"Name":f"{cape_names[job][0]}", "Name2":f"{cape_names[job][0]} {base_stat} {main_stat}", "Accuracy":20, "Attack":20, "PDT":-10, f"{base_stat}":30, f"{main_stat}":10}, **{i:cape_names[job][1][i] for i in cape_names[job][1]}})
        if job in ["NIN", "RDM", "WHM", "BLM", "SCH", "GEO", "DRK", "WAR", "SAM", "RNG", "THF"] and base_stat in ["INT", "MND", "Str", "DEX", "AGI"]: # List of jobs that use magic weapon skills
            if job=="SAM" and base_stat!="Str": # SAM only needs STR+WSD (probably)
                continue
            # Add capes with Macc+Mdmg + WSD + STAT
            capes.append({**{"Name":f"{cape_names[job][0]}", "Name2":f"{cape_names[job][0]} {base_stat} Weapon Skill Damage (Magic)", f"{base_stat}":30, "Weapon Skill Damage":10, "Magic Accuracy":20, "Magic Damage":20, "PDT":-10}, **{i:cape_names[job][1][i] for i in cape_names[job][1]}})

        if job in ["NIN", "RDM", "COR", "RNG", "SAM", "THF"] and base_stat in ["AGI", "Str", "DEX"]: # The list of jobs that might build physical ranged WS sets.
            # add ranged WS sets with stat+30, WSD+10, Racc/Ratk+20 for a select few jobs. Only RNG gets a DEX cape, but it should use crit rate for jishnus  TODO
            # capes.append({**{"Name":f"{cape_names[job][0]}", "Name2":f"{cape_names[job][0]} {base_stat} Weapon Skill Damage (Ranged)", f"{base_stat}":30, "Weapon Skill Damage":10, "Ranged Accuracy":20, "Ranged Attack":20, "DT":-5}, **{i:cape_names[job][1][i] for i in cape_names[job][1]}})
            for main_stat in ["Weapon Skill Damage", "Crit Rate", "Store TP"]:
                capes.append({**{"Name":f"{cape_names[job][0]}", "Name2":f"{cape_names[job][0]} {base_stat} {main_stat} (Ranged)", f"{base_stat}":30, f"{main_stat}":10, "Ranged Accuracy":20, "Ranged Attack":20, "PDT":-10}, **{i:cape_names[job][1][i] for i in cape_names[job][1]}})


    if job in ["NIN", "BLM", "RDM", "SCH", "GEO", "DRK"]: # The list of jobs with access to nukes get nuke capes
        # add nuking capes with INT+30, Matk+10, Macc/Mdmg+20 for a select few jobs.
        capes.append({**{"Name":f"{cape_names[job][0]}", "Name2":f"{cape_names[job][0]} INT Magic Attack", "INT":30, "Magic Attack":10, "Magic Accuracy":20, "Magic Damage":20, "PDT":-10}, **{i:cape_names[job][1][i] for i in cape_names[job][1]}})
    if job in ["COR"]: # COR needs an AGI+Matk cape for quick draw. AGI improves Macc for QD apparently
        capes.append({**{"Name":f"{cape_names[job][0]}", "Name2":f"{cape_names[job][0]} AGI Magic Attack (Magic)", "AGI":30, "Magic Attack":10, "Magic Accuracy":20, "Magic Damage":20, "PDT":-10}, **{i:cape_names[job][1][i] for i in cape_names[job][1]}})

# We now have an Ambuscade cape for all jobs with all combinations of stats that we care about.






typo = False
slots = [mains, subs, grips, ranged, ammos, heads, necks, ears, ears2, bodies, hands, rings, rings2, capes, waists, legs, feet]
for slot in slots:
  for gear in slot:
    keys = gear.keys()
    for key in keys:
      if key not in available_stats:
        print(f"Incorrect stat name found on \"{gear.get('Name2',gear['Name'])}\":  \"{key}\"")
        typo = True
    if not gear.get("Jobs",False):
        print(f"Missing the Jobs key-value pair: {gear['Name']}")

    # May as well add the "Name2" value to all items that do not have it. This is huge for cleaning up the main code
    # While they do not have a typed-out "Name2", as long as another code uses this code, then each piece of gear will have "Name2" available now.
    # I'll clean up the main code later.
    name2 = gear.get('Name2', 'None')
    if name2 == 'None':
        gear.update({'Name2': gear['Name']})

# Make sure each weapon, ammo, grip, shield, and ranged weapon has a "Type" and "Skill Type" key.
for k in mains+subs+grips+ranged:
    if not k.get("Skill Type", False):
        print(f"Add a \"Skill Type\" key to {k['Name2']}!  Typically: (Club, Dagger, Sword, Katana, . . . and None)\nOr make sure you put the item in the correct list. (arrows/bullets go in the \"ammos\" list)")

for k in mains+subs+grips+ranged+ammos:
    if k["Name"]=="Empty":
        continue
    if k.get("Type", "None") not in ["Weapon", "Grip", "Shield", "Gun", "Bow", "Crossbow", "Shuriken", "Bullet", "Arrow", "Bolt", "Equipment", "Instrument"]:
        print(f"Add a \"Type\" key to {k['Name2']}!  The only options are: (Weapon, Grip, Shield, Gun, Crossbow, Bow, Shuriken, Bullet, Arrow, Bolt, Equipment).")

if typo:
  print("Check the \"available_stats\" list at the end of the gear.py file for a list of accepted stat names.")
  import sys ; sys.exit()