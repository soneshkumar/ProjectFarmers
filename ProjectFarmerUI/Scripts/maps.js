function initMap() {
	var map = new google.maps.Map(document.getElementById('map'), {
		zoom: 12,
		center: {lat: 26.935254, lng: 75.769174},  // map will be centered around this coordinate
		mapTypeId: 'roadmap'
	});

  // Define the LatLng coordinates for the polygon's path.
  var serviceareacoords = [
	{lat: 27.007255, lng: 75.785399},
	{lat: 27.001137, lng: 75.789175},
	{lat: 27.006643, lng: 75.797758},
	{lat: 26.996243, lng: 75.795698},
	{lat: 26.988594, lng: 75.789175},
	{lat: 26.965197, lng: 75.791155},
	{lat: 26.943992, lng: 75.806493},
	{lat: 26.932475, lng: 75.810570},
	{lat: 26.931576, lng: 75.820054},
	{lat: 26.917002, lng: 75.816623},
	{lat: 26.903866, lng: 75.814202},
	{lat: 26.894868, lng: 75.808552},
	{lat: 26.886769, lng: 75.802498},
	{lat: 26.885689, lng: 75.795435},
	{lat: 26.880829, lng: 75.766982},
	{lat: 26.879569, lng: 75.748618},
	{lat: 26.875789, lng: 75.725613},
	{lat: 26.878489, lng: 75.716533},
	{lat: 26.901886, lng: 75.710277},
	{lat: 26.924379, lng: 75.705636},
	{lat: 26.951724, lng: 75.701801},
	{lat: 26.972408, lng: 75.711286},
	{lat: 27.000858, lng: 75.730995},
	{lat: 27.012116, lng: 75.769189}
  ];

  // Construct the service area.
  var servicearea = new google.maps.Polygon({
	paths: serviceareacoords,
	strokeColor: '#0092ff',
	strokeOpacity: 0,
	strokeWeight: 0,
	fillColor: '#0092ff',
	fillOpacity: 0.2
  });
  servicearea.setMap(map);
}