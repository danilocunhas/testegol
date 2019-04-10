import { Injectable } from '@angular/core';
import { AirPlane } from '../model/airplane.model';
import { HttpClient } from '@angular/common/http';
import { AIRPLANE_API } from '../app.config';
@Injectable({
  providedIn: 'root'
})
export class AirplaneService {

  constructor(private http: HttpClient) { }

  getAirPlanes() {
    return this.http.get<AirPlane[]>(AIRPLANE_API);
  }

  getAirPlanesById(id: number) {
    return this.http.get<AirPlane[]>(`${AIRPLANE_API}/${id}`);
  }

  createAirplane(airplane: AirPlane) {
    return this.http.post(AIRPLANE_API, airplane);
  }

  updateAirplane(airplane: AirPlane) {
    return this.http.put(AIRPLANE_API, airplane);
  }

  deleteAirplane(id: number) {
    return this.http.delete(`${AIRPLANE_API}/${id}`);
  }

}
