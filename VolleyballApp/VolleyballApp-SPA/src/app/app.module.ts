import { BrowserModule, HammerGestureConfig, HAMMER_GESTURE_CONFIG } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { BsDropdownModule, BsDatepickerModule, PaginationModule, ButtonsModule, TabsModule, ModalModule } from 'ngx-bootstrap';
import { NgxNavbarModule } from 'ngx-bootstrap-navbar';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { AuthService } from './_services/auth.service';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { ErrorInterceptorProvider } from './_services/error.interceptor';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MessagesComponent } from './messages/messages.component';
import { appRoutes } from './routes';
import { MemberCardComponent } from './members/member-card/member-card.component';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { MemberEditComponent } from './members/member-edit/member-edit.component';
import { TeamListComponent } from './teams/team-list/team-list.component';
import { TeamCardComponent } from './teams/team-card/team-card.component';
import { TeamCreateComponent } from './teams/team-create/team-create.component';
import { MessagesResolver } from './_resolvers/messages.resolver';
import { MemberListResolver } from './_resolvers/member-list.resolver';
import { AuthGuard } from './_guards/auth.guard';
import { JwtModule } from '@auth0/angular-jwt';
import { TeamListResolver } from './_resolvers/team-list.resolver';
import { MemberDetailResolver } from './_resolvers/member-detail.resolver';
import { MemberEditResolver } from './_resolvers/member-edit.resolver';
import { PreventUnsavedChanges } from './_guards/prevent-unsaved-changes.guard';
import { InviteCardComponent } from './invites/invite-card/invite-card.component';
import { InviteListComponent } from './invites/invite-list/invite-list.component';
import { InviteListResolver } from './_resolvers/invite-list.resolver';
import { FriendListResolver } from './_resolvers/friend-list.resolver';
import { MemberFriendListComponent } from './members/member-friend-list/member-friend-list.component';
import { TimeAgoPipe } from 'time-ago-pipe';
import { NgPipesModule } from 'ngx-pipes';
import { TeamDetailComponent } from './teams/team-detail/team-detail.component';
import { TeamDetailResolver } from './_resolvers/team-detail.resolver';
import { MatchListComponent } from './matches/match-list/match-list.component';
import { MatchListResolver } from './_resolvers/match-list.resolver';
import { MatchCardComponent } from './matches/match-card/match-card.component';
import { MatchDetailComponent } from './matches/match-detail/match-detail.component';
import { MatchDetailResolver } from './_resolvers/match-detail.resolver';
import { FileUploadModule } from 'ng2-file-upload';
import { PhotoEditorComponent } from './members/photo-editor/photo-editor.component';
import { MemberMessagesComponent } from './members/member-messages/member-messages.component';
import { TeamPhotoComponent } from './teams/team-photo/team-photo.component';
import { OwlDateTimeModule, OwlNativeDateTimeModule } from 'ng-pick-datetime';
import { LeagueListResolver } from './_resolvers/league-list.resolver';
import { LeaguesListComponent } from './leagues/leagues-list/leagues-list.component';
import { LeaguesCardComponent } from './leagues/leagues-card/leagues-card.component';
import { LeagueDetailResolver } from './_resolvers/league-detail.resolver';
import { LeagueDetailComponent } from './leagues/league-detail/league-detail.component';
import { MatchesForLeagueResolver } from './_resolvers/matches-for-league.resolver';
import { MatchRefereeListResolver } from './_resolvers/match-referee-list.resolver';
import { MatchRefereeListComponent } from './matches/match-referee-list/match-referee-list.component';
import { MatchRefereeDataComponent } from './matches/match-referee-data/match-referee-data.component';
import { ActivateComponent } from './activate/activate.component';
import { ActivateLinkComponent } from './activate-link/activate-link.component';
import { LeagueFormComponent } from './leagues/league-form/league-form.component';



export function tokkenGetter() {
   return localStorage.getItem('token');
}

export class CustomHammerConfig extends HammerGestureConfig  {
   overrides = {
       pinch: { enable: false },
       rotate: { enable: false }
   };
}

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      HomeComponent,
      ActivateComponent,
      ActivateLinkComponent,
      RegisterComponent,
      MemberListComponent,
      MemberCardComponent,
      MemberEditComponent,
      MessagesComponent,
      TeamListComponent,
      TeamCardComponent,
      TeamCreateComponent,
      TeamDetailComponent,
      MemberDetailComponent,
      InviteCardComponent,
      InviteListComponent,
      MemberFriendListComponent,
      MemberMessagesComponent,
      TeamDetailComponent,
      MatchListComponent,
      MatchRefereeListComponent,
      MatchRefereeDataComponent,
      MatchCardComponent,
      MatchDetailComponent,
      PhotoEditorComponent,
      LeaguesListComponent,
      LeagueDetailComponent,
      LeagueFormComponent,
      TeamPhotoComponent,
      LeaguesCardComponent,
      TimeAgoPipe,
      ActivateComponent,
      ActivateLinkComponent
   ],
   imports: [
      BrowserModule,
      BrowserAnimationsModule,
      HttpClientModule,
      FormsModule,
      NgPipesModule,
      ReactiveFormsModule,
      FileUploadModule,
      BsDropdownModule.forRoot(),
      TabsModule.forRoot(),
      ModalModule.forRoot(),
      PaginationModule.forRoot(),
      ButtonsModule.forRoot(),
      BsDatepickerModule.forRoot(),
      NgxNavbarModule,
      OwlDateTimeModule,
      OwlNativeDateTimeModule,
      RouterModule.forRoot(appRoutes),
      JwtModule.forRoot({
         config: {
            tokenGetter: tokkenGetter,
            whitelistedDomains: ['localhost:5000'],
            blacklistedRoutes: ['localhost:5000/api/auth']
         }
      })
   ],
   providers: [
      AuthService,
      ErrorInterceptorProvider,
      MessagesResolver,
      MemberListResolver,
      MemberEditResolver,
      InviteListResolver,
      TeamDetailResolver,
      TeamListResolver,
      MemberDetailResolver,
      FriendListResolver,
      MatchListResolver,
      MatchDetailResolver,
      LeagueListResolver,
      LeagueDetailResolver,
      MatchesForLeagueResolver,
      MatchRefereeListResolver,
      AuthGuard,
      PreventUnsavedChanges,
      { provide: HAMMER_GESTURE_CONFIG, useClass: CustomHammerConfig }
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
