import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { AirplaneService } from 'src/app/service/airplane.service';

@Component({
  selector: 'app-add-airplane',
  templateUrl: './add-airplane.component.html'
})
export class AddAirplaneComponent implements OnInit {

  addForm: FormGroup;

  constructor(private formBuilder: FormBuilder, private router: Router, private airplaneService: AirplaneService) { }

  ngOnInit() {

    this.addForm = this.formBuilder.group({
      id: 0,
      code: ['', Validators.required],
      model: ['', Validators.required],
      numberOfPassengers: ['', Validators.required]
    });
  }

  onSubmit() {
    this.airplaneService.createAirplane(this.addForm.value)
      .subscribe( data => {
        this.router.navigate(['list-airplane']);
      });
  }

}
