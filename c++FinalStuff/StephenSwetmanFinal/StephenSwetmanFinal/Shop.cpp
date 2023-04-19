#pragma once
#include "Shop.h"

using namespace std;
//Empty shop constructor
Shop::Shop() {

}

//Deletes shop inventory
void Shop::delShopInv(int j) {
	shopInv.erase(shopInv.begin() + j);
	shopPrice.erase(shopPrice.begin() + j);
}

//Add shop inventory
void Shop::addShopInv(string item,double price) {
	shopInv.push_back(item);
	shopPrice.push_back(price);
}

//View shop inventory
void Shop::viewShopInv() {
	//Check to see if shop inventory is empty
	if (shopInv.size() > 0) {
		cout << "\nOur items" << endl;

		//Loop through shop invenotry and return items with prices
		for (int i = 0; i < shopInv.size(); ++i) {
			cout << shopInv[i] << "\t" << "Price: " << shopPrice[i] << endl;
		}
	}
	else {
		cout << "I have nothing to buy!" << endl;
	}
}

//Pricing function
int Shop::pricer(string item) {
	int retPrice = 0;

	if (item == "Sword") {
		retPrice = 100;
	}
	else if (item == "BattleAxe") {
		retPrice = 200;
	}
	else if (item == "Spear") {
		retPrice = 250;
	}
	else if (item == "MedKit") {
		retPrice = 200;
	}
	else if (item == "key") {
		retPrice = 0;
	}
	return retPrice;
}
