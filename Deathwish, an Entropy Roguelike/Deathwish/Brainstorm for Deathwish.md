- Begin with a party of ~4
	- Each one is an adventurer searching for the Deathwish, the greatest spell ever invented, that grants the caster anything they could want in exchange for their life
	- Begin at home base, with a permanent character for permanent upgrades, and maybe more home base characters as the party progresses
	- Travel through worlds until the Deathwish is reached at the end of the seventh
		- Forest with stealthy enemies, mess with lighting and awareness. Theme with plants and wild animals, then horror story style monsters for bosses.
			- Player level 1-5
			- Item level 1 and 2 legendary 3s
		- Ocean with mobility enemies, swapping from land to sea and outranging players. Theme with fish and pirates, then oilpunk nightmares for bosses
			- Player Level 6-10
			- Item level 3 and 4 legendary 5s
		- Arcane-lands with status effects, nerfing players until they struggle to fight. Theme with outcast magicians in wild ethereal lands, then elementals and failed experiments for bosses.
			- Player Level 11-15
			- Item level 5 and 6 legendary 7s
		- Industrial with tactical enemies, using cover and team tactics to swarm players. Theme with post war destruction and soldiers, then great war machines for bosses
			- Player Level 16-20
			- Item level 6 and 7 legendary 8s
		- Cybercity with tanky enemies, immovable threats that constantly advance. Theme cyberpunk but devoid of humanity, with tangled bio-amalgams as bosses.
			- Player Level 21-25
			- Item level 7 and 8 legendary 9s
		- Extraplanar with unique enemies, flipping the rules and never expected. Theme as eldritch horror beyond comprehension, non-Euclidian and non-sensical bosses
			- Player Level 26-30
			- Item level 8 and 9 legendary 10s
		- Finale, the Pacifist, refuses to kill the party or let them access the Deathwish. Believes no-one should have to die ever, must be convinced through conversation.
			- The party's knowledge of the story, and moral reasoning should let them convince the Pacifist of a more nuanced truth
	- The players are expected to die many times, upgrading after each death, and finding a new dungeon each time
	- As they play again and again, they will learn more about the world of the Deathwish, find other characters also searching for it, and face moral quandaries of legacy and sacrifice
- Run through a tree of randomly generated rooms
    - Types:
	    - Combat
		    - Tests physical
		    - Rewards with items, levels, and currency
	    - Boss
		    - Tests physical
		    - Rewards with passage to the next world and a strong item
	    - Loot
		    - Tests mental
		    - Rewards with items, currency, and ingredients
	    - Event
		    - Tests mental
		    - Rewards with anything
	    - Store
		    - Tests personal
		    - Costs currency
		    - Rewards with items, hints and information on future rooms
	    - Civilisation
		    - Tests personal
		    - Rewards with downtime, companions, and story
		- Lore
			- Rewards with story
			- Fuck these actually, just make them events
- Players should level up at 10XP then at 25XP then 45 XP
	- XP to get into lvl n = 2.5n^2 +2.5n - 5
- Currency is in crystal coins:
	- 1 Feldspar coin = 10 Quartz coins
	- 1 Garnet coin = 10 Feldspar coins
	- 1 Beryl coin = 10 Garnet coins
	- 1 Diamond coin = 10 Beryl coins
- Algorithm for Dungeon Generation
	- Begin at starting room
	- 2d2 + 2 exits
	- Each exit has a 1d4 = 1 chance to be locked, a locked door will show what type of room it is
	- decide each room's type with the d10 table:

| d10 | Room type                                            |
| --- | ---------------------------------------------------- |
| 0   | Combat                                               |
| 1   | Combat                                               |
| 2   | Combat                                               |
| 3   | Combat                                               |
| 4   | Shop                                                 |
| 5   | Shop                                                 |
| 6   | Civilisation                                         |
| 7   | Event                                                |
| 8   | Event                                                |
| 9   | Reroll, after 3 rerolls in total automatic boss room |
	- After ten rooms, there is a boss room anyway
- Different item types can function on different items
	- Grimoires give three charges of a spell for 1 AP each
	- Tonics grant a learned bonus
	- Manuals grant a learned move
	- Scrolls teach a spell