#pragma once
#include<iostream>
#include<vector>
#include"Map.h"
using namespace std;


Map::Map() {

	//Camp
	Room* p1 = new Room("\nYou are in Camp. ", "You see a draw bridge that leads into the open world, you are standing next to the fire, across from you is a mysterious merchant");
	rVec.push_back(p1);
	p1->rInventory.push_back("Sword");



	//Stoner field
	Room* p2 = new Room("\nYou have entered Stoner Field. ", "You can barely see, the area seems more dense with fog than usual");
	rVec.push_back(p2);
	p2->enemy->risenDead();
	p2->enemy2->direBat();

	//Dead Marsh
	Room* p3 = new Room("\nYou have entered Dead Marsh ", "You enter a Swampland like area, you can hear something that resembles a horrible screeching noise");
	rVec.push_back(p3);
	p3->enemy->direBat();
	p3->enemy->eInv.push_back("MedKit");

	//Cave
	Room* p4 = new Room("\nYou have entered a Cave ", "The air is cold and damp, you see little light except some torch lights reflecting of the caves walls deper into the cave");
	rVec.push_back(p4);
	p4->enemy->fallen();
	p4->enemy->eInv.push_back("MedKit");
	p4->enemy->eInv.push_back("key");

	//Horror Forrest
	Room* p5 = new Room("\nYou have entered Horror Forrest ", "It is really dark, you are able to make out some figures in the shadows. Are those horns?");
	rVec.push_back(p5);
	p5->enemy->moonClan();
	p5->enemy->eInv.push_back("BattleAxe");

	//Dark Woods
	Room* p6 = new Room("\nYou have entered Dark Woods ", "Have I been here before?");
	rVec.push_back(p6);
	
	//Sanctum	
	Room* p7 = new Room("\nYou have entered Sanctum ", "There are torch lights on the walls and it appears to be safe, there are a set of old wooden storm shelter doors in the middle of the room, it would seem to lead down");
	rVec.push_back(p7);

	//North East Wing
	Room* p8 = new Room("\nYou have entered North East Wing ", "There are torch lights on the walls and it appears to be safe, I should look around for supplies");
	rVec.push_back(p8);
	p8->rInventory.push_back("MedKit");

	//Into Lost Sanctum	
	Room* p9 = new Room("\nNow entering Lost Sanctum ", "You can feel the stale air and feel some sort of Ancient power");
	rVec.push_back(p9);

	//Treasure Room1 
	Room* p10 = new Room("\nNow entering A treasure Room ", "I should look around there may be something of some value here");
	rVec.push_back(p10);
	p10->rInventory.push_back("MedKit");
	p10->rInventory.push_back("MedKit");
	p10->rInventory.push_back("Armor");

	//Sacrifice Prep Room
	Room* p11 = new Room("\nNow entering Sacrifice Preperation Room ", "This place is cold I can feel the terror in the room");
	rVec.push_back(p11);
	p11->enemy->soulEater();
	p11->enemy->eInv.push_back("MedKit");

	//Sacrifice Alter
	Room* p12 = new Room("\nNow entering Sacrifice Alter ", "Great evil took place here");
	rVec.push_back(p12);
	p12->enemy->fallen();

	//Armory
	Room* p13 = new Room("\nNow Armory ", "I should look for gear");
	rVec.push_back(p13);
	p13->rInventory.push_back("Spear");

	//Prison
	Room* p14 = new Room("\nNow entering Prison ", "I better be on \"Guard\"");
	rVec.push_back(p14);
	p14->enemy->warden();
	p14->enemy->eInv.push_back("MedKit");
	p14->enemy->eInv.push_back("MedKit");
	p14->enemy->eInv.push_back("key");

	//Torture Chamber
	Room* p15 = new Room("\nNow entering Torture Chamber ", "The smell in here is enough to make the demons run and hide");
	rVec.push_back(p15);
	p15->enemy->risenDead();
	p15->enemy2->risenDead();


	//Lost Sanctum Level 2
	Room* p16 = new Room("\nNow entering Lost Sanctum Level 2 ", "The better the fight the stronger I feel");
	rVec.push_back(p16);

	//Room of enchantment
	Room* p17 = new Room("\nNow entering Room of Enchantment ", "I should take a look around");
	rVec.push_back(p17);
	p17->rInventory.push_back("Amulet");

	//Magi Study
	Room* p19 = new Room("\nNow entering MAGI Study ", "There is great power here");
	rVec.push_back(p19);

	//Cathedral
	Room* p20 = new Room("\nNow entering Cathedral ", "These grounds feel unholy");
	rVec.push_back(p20);

	//Arcane Sanctuary
	Room* p21 = new Room("\nNow entering Arcane Sanctuary ", "There is Dark Magic here");
	rVec.push_back(p21);
	p21->enemy->summoner();
	p21->enemy->eInv.push_back("key");
	p21->enemy->eInv.push_back("MedKit");

	//Rune Library
	Room* p22 = new Room("\nNow entering Rune Library ", "There is more to learn");
	rVec.push_back(p22);
	p22->rInventory.push_back("Scroll");
	
	//Treasure room 2
	Room* p23 = new Room("\nNow entering Treasure Room 2 ", "I should see if there is anything valuable lying around");
	rVec.push_back(p23);
	p23->rInventory.push_back("MedKit");
	p23->rInventory.push_back("MedKit");
	p23->rInventory.push_back("Shield");

	//Lost Sanctum Level 3
	Room* p25 = new Room("\nNow entering Lost Sanctum Level 3 ", "The farther I go the more darkness surrounds me");
	rVec.push_back(p25);

	//Treasure room 3
	Room* p26 = new Room("\nNow entering Treasure Room 3 ", "There seems to be great wealth here");
	rVec.push_back(p26);
	p26->rInventory.push_back("Amulet");
	p26->rInventory.push_back("Helm");


	//Alchemy Tomb
	Room* p27 = new Room("\nNow entering Alchemy Tomb ", "There seems to be more knowledge here");
	rVec.push_back(p27);
	p27->enemy->moonClan();
	p27->enemy2->frozenHorror();
	p27->enemy2->eInv.push_back("key");
	
	//Final Boss
	Room* p28 = new Room("\nYou have reached the Throne Of Destruction ", "I hope everything I have been through has prepared me to vanguish this great Evil");
	rVec.push_back(p28);
	p28->enemy->lordOfDestruction();

	mStart = p1; //Set start position of map
	mEnd = p28;
	mStart->shop = new Shop;

	//Camp
	p1->pEast = p2;
	p1->pNorth = 0;
	p1->pWest = 0;
	p1->pSouth = 0;
	p1->pDown = 0;
	p1->pUp = 0;

	//Stoner Field
	p2->pSouth = 0;
	p2->pNorth = p3;
	p2->pEast = p4;
	p2->pWest = p1;
	p2->pUp = 0;
	p2->pDown = 0;

	//Dead Marsh
	p3->pEast = p7;
	p3->pWest = p5;
	p3->pSouth = p2;
	p3->pNorth = 0;
	p3->pUp = 0;
	p3->pDown = 0;

	//Cave
	p4->pEast = 0;
	p4->pNorth = 0;
	p4->pSouth = 0;
	p4->pWest = p2;
	p4->pUp = 0;
	p4->pDown = 0;

	//Horror Forest
	p5->pEast = p3;
	p5->pNorth = p6;
	p5->pSouth = 0;
	p5->pWest = p6;
	p5->pUp = 0;
	p5->pDown = 0;

	//Dark Woods
	p6->pEast = p5;
	p6->pNorth = 0;
	p6->pSouth = p5;
	p6->pWest = 0;
	p6->pUp = 0;
	p6->pDown = 0;

	//Sanctum
	p7->pEast = p8; 
	p7->pNorth = 0;
	p7->pSouth = 0;
	p7->pWest = p3;
	p7->pUp = 0;
	p7->pDown = p9;

	//North East Wing
	p8->pEast = 0;
	p8->pNorth = 0;
	p8->pSouth = 0;
	p8->pWest = p7;
	p8->pUp = 0;
	p8->pDown = p12;

	//Into Lost Sanctum
	p9->pEast = p11;
	p9->pNorth = 0;
	p9->pSouth = 0;
	p9->pWest = p10;
	p9->pDown = 0;
	p9->pUp = p7;
	p9->pWest->locked = true;

	//Treasure Room1
	p10->pEast = p9;
	p10->pNorth = 0;
	p10->pSouth = 0;
	p10->pWest = 0;
	p10->pUp = 0;
	p10->pDown = 0;


	//Sacrifice Prep Room
	p11->pEast = p12; 
	p11->pNorth = p13; 
	p11->pSouth = p14; 
	p11->pWest = p9; 
	p11->pUp = 0;
	p11->pDown = 0;

	//Sacrifice Alter
	p12->pEast = 0; 
	p12->pNorth = 0; 
	p12->pSouth = p15; 
	p12->pWest = p11;
	p12->pUp = p8;
	p12->pDown = 0;

	//Armory
	p13->pEast = 0;
	p13->pNorth = 0; 
	p13->pSouth = p11; 
	p13->pWest = 0;
	p13->pUp = 0;
	p13->pDown = 0;

	//Prison
	p14->pEast = p15;
	p14->pNorth = p11;
	p14->pSouth = 0;
	p14->pWest = 0;
	p14->pUp = 0;
	p14->pDown = 0;
	p14->pEast->locked = true;

	//Torture Chamber
	p15->pEast = 0;
	p15->pNorth = p12;
	p15->pSouth = 0;
	p15->pWest = p14;
	p15->pUp = 0;
	p15->pDown = p16;

	//Lost Sanctum Level 2
	p16->pEast = 0;
	p16->pNorth = 0;
	p16->pSouth = p17;
	p16->pWest = p21; 
	p16->pUp = p15;
	p16->pDown = 0;

	//Room of Enchantment
	p17->pEast = 0;
	p17->pNorth = p16;
	p17->pSouth = p20;
	p17->pWest = 0;
	p17->pUp = 0;
	p17->pDown = 0;





	//Cathedral
	p20->pEast = 0;
	p20->pNorth = p17;
	p20->pSouth = 0;
	p20->pWest = p22;
	p20->pUp = 0;
	p20->pDown = p25;


	//Arcane Sanctuary
	p21->pEast = p16;
	p21->pNorth = p23;
	p21->pSouth = p22;
	p21->pWest = 0;
	p21->pUp = 0;
	p21->pDown = 0;
	p21->pNorth->locked = true;

	//Rune Library
	p22->pEast = p20;
	p22->pNorth = p21;
	p22->pSouth = 0;
	p22->pWest = 0;
	p22->pUp = 0;
	p22->pDown = 0;

	//Treasure Room2
	p23->pEast = 0;
	p23->pNorth = 0;
	p23->pSouth = p21;
	p23->pWest = 0;
	p23->pUp = 0;
	p23->pDown = 0;


	//Lost Sanctum Level 3
	p25->pEast = p26;
	p25->pNorth = 0;
	p25->pSouth = 0;
	p25->pWest = p27;
	p25->pUp = p20;
	p25->pDown = 0;
	p25->pEast->locked = true;

	//Treasure Room 3
	p26->pEast = 0; 
	p26->pNorth = 0;
	p26->pSouth = 0;
	p26->pWest = p25;
	p26->pUp = 0;
	p26->pDown = 0;

	//Alchemy Tomb
	p27->pEast = p25;
	p27->pNorth = 0;
	p27->pSouth = p28;
	p27->pWest = p25;
	p27->pUp = 0;
	p27->pDown = 0;


	//Final Boss
	p28->pEast = 0;
	p28->pNorth = p27;
	p28->pSouth = 0;
	p28->pWest = 0;
	p28->pUp = 0;
	p28->pDown = 0;
}


//Map destructor deletes all rooms
Map::~Map() {
	for (int i = rVec.size() - 1; i >= 0; --i) {
		rVec.pop_back();
}
}