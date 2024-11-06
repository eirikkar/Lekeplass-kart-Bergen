/**
 * @license
 * Copyright 2019 Google LLC. All Rights Reserved.
 * SPDX-License-Identifier: Apache-2.0
 */
async function initMap() {
  // Request needed libraries.
  const { Map, InfoWindow } = await google.maps.importLibrary("maps");
  const { AdvancedMarkerElement, PinElement } = await google.maps.importLibrary(
    "marker"
  );
  const map = new Map(document.getElementById("map"), {
    zoom: 11,
    center: { lat: 60.336617, lng: 5.30129 },
    mapId: "4504f8b37365c3d0",
  });
  // Set LatLng and title text for the markers. The first marker (Boynton Pass)
  // receives the initial focus when tab is pressed. Use arrow keys to move
  // between markers; press tab again to cycle through the map controls.
  const lekeplasser = [
    {
      position: { lat: 60.336617, lng: 5.30129 },
      title: "Bønesparken",
    },
    {
      position: { lat: 34.8559195, lng: -111.7988186 },
      title: "Airport Mesa",
    },
    {
      position: { lat: 34.832149, lng: -111.7695277 },
      title: "Chapel of the Holy Cross",
    },
    {
      position: { lat: 34.823736, lng: -111.8001857 },
      title: "Red Rock Crossing",
    },
    {
      position: { lat: 34.800326, lng: -111.7665047 },
      title: "Bell Rock",
    },
  ];
  // Create an info window to share between markers.
  const infoWindow = new InfoWindow();

  // Create the markers.
  lekeplasser.forEach(({ position, title }, i) => {
    const pin = new PinElement({
      glyph: `${i + 1}`,
      scale: 1,
    });
    const marker = new AdvancedMarkerElement({
      position,
      map,
      title: `${i + 1}. ${title}`,
      content: pin.element,
      gmpClickable: true,
    });

    // Add a click listener for each marker, and set up the info window.
    marker.addListener("click", ({ domEvent, latLng }) => {
      const { target } = domEvent;

      infoWindow.close();
      infoWindow.setContent(marker.title);
      infoWindow.open(marker.map, marker);
    });
  });
}

initMap();
