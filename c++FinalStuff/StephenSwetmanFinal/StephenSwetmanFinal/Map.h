#pragma once
#include<iostream>
#include"Room.h"
using namespace std;

class Map
{
public:
	vector<Room*>rVec;
	Map();
	~Map();
	Room* mStart;
	Room* mEnd;
};
