import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserAuthorization } from '../models/user-authorization.model';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-user-authorization',
  templateUrl: './user-authorization.component.html',
  styleUrls: ['./user-authorization.component.css']
})
export class UserAuthorizationComponent implements OnInit {

  form: FormGroup;
  private formSubmitAttempt: boolean;
  showError = false;

  constructor(
    private fb: FormBuilder,
    private userService: UserService,
    private router: Router
  ) {}

  ngOnInit() {
    this.form = this.fb.group({
      Email: ['', Validators.required],
      Password: ['', Validators.required]
    });
  }

  isFieldInvalid(field: string) {
    return (
      (!this.form.get(field).valid && this.form.get(field).touched) ||
      (this.form.get(field).untouched && this.formSubmitAttempt)
    );
  }

  onSubmit() {
    if(this.form.valid){
      let user = this.form.value;
      this.userService.login(user).subscribe(
        (resp) => { localStorage.setItem('auth', 'true'); this.router.navigateByUrl('/') },
        (error) => { localStorage.setItem('auth', 'false'); this.showError = true; }
      );
    }
    this.formSubmitAttempt = true;
  }
}
