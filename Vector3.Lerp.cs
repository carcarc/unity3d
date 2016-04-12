// Smoothly move between the camera's current position and it's target position.
transform.position = Vector3.Lerp (start.position, end.position, Time.deltaTime);
