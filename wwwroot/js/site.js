﻿/**
 * @license
 * Copyright 2019 Google LLC. All Rights Reserved.
 * SPDX-License-Identifier: Apache-2.0
 */

// This code is based on the example code from goolgle maps
// Creates the map and fetches data from api/lekeplasser
async function initMap() {
  const { Map, InfoWindow } = await google.maps.importLibrary("maps");
  const { AdvancedMarkerElement, PinElement } = await google.maps.importLibrary(
    "marker"
  );
  const map = new Map(document.getElementById("map"), {
    zoom: 11,
    center: { lat: 60.336617, lng: 5.30129 },
    mapId: "f6c0820cd736c60",
  });

  fetch("/api/lekeplasser")
    .then((response) => response.json())
    .then((lekeplasser) => {
      const infoWindow = new InfoWindow();

      lekeplasser.forEach(({ lat, long, name }, i) => {
        const position = {
          lat: parseFloat(lat),
          lng: parseFloat(long),
        };
        const pin = new PinElement({
          glyph: `${i + 1}`,
          scale: 1,
          background: "#fb6304",
          borderColor: "#137333",
          glyphColor: "white",
        });
        const marker = new AdvancedMarkerElement({
          position,
          map,
          title: `${i + 1}. ${name}`,
          content: pin.element,
          gmpClickable: true,
        });
        marker.addListener("click", () => {
          infoWindow.setContent(`
            <div id="infobox">
              <h3>${name}</h3>
            </div>
          `);
          infoWindow.open(map, marker);
        });
      });
    })
    .catch((error) => {
      console.error("Error fetching lekeplasser data:", error);
    });
}

initMap();
