import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { UserServiceService } from '../services/user-service.service';
import { Observable } from 'rxjs';
import { User } from '../models/user';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent implements OnInit {
  formUser: FormGroup;
  allUsers: Observable<User[]>;
  constructor(private fb: FormBuilder, private userService: UserServiceService) { }

  ngOnInit() {
    this.formUser = this.fb.group({
      FirstName: new FormControl('', [Validators.required, Validators.maxLength(30)]),
      LastName: new FormControl('', [Validators.required, Validators.maxLength(30)]),
      Participation: new FormControl('', [Validators.required]),
    });
    this.loadAllUsers();
  }


  save() {
    if (this.formUser.invalid) {
      return;
    }
    const user = this.formUser.value;
    this.userService.createUser(user).subscribe(
      () => {
        this.loadAllUsers();
      }
    );
  }

  loadAllUsers() {
    this.allUsers = this.userService.getAllUsers();
  }
}
