const { planetSizer } = require("./services");

// We are space invaders who want to conquer some new universe! Our computer randomly chooses one of the planets and drops off our battle vehicle.

// If we are able to travel around the whole equator of the planet and spread the spores of some special bacteria - the population will be eradicated, and the planet will be ours! (Mwahaha!)

// You are a key member of the Command and Conquer Center mega brain system and need to prepare for the attack by making sure that we have enough fuel and seeds to take over a given planet.

// Our intelligence services provided us with the following information:
// a service that returns the length of the equator in km (Circumference) for a given PlanetName
// a service that returns the number of litres of fuel and tons of seeds for traveling a given distance in km

// Our application should communicate with our minions via the interface of the Trans Hyper Msg Broker:
// if we have enough fuel and seeds we can send the “Conquer!11” command to our forces
// if we don’t have enough of something, we can contact our warehouses to refill the corresponding goods.


// Ahoy There!
function invade(planetName) {
  const planetSize = planetSizer(planetName);
  return planetSize;
}

module.exports = invade;
