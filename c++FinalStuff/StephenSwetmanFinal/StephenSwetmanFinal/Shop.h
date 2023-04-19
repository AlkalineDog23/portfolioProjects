#pragma once
#include<iostream>
#include<string>
#include<vector>

using namespace std;

class Shop {
public:
	vector<string>shopInv;  //Shop inventory
	vector<double>shopPrice; //Shop Prices

	Shop();
	~Shop();
	void delShopInv(int j);
	void addShopInv(string item,double price);
	void viewShopInv();
	int pricer(string item);


private:
};