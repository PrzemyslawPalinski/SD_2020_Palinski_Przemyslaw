import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Invite } from '../_models/invite';
import { PaginatedResult } from '../_models/pagination';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})
export class FriendInviteService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient, private authService: AuthService) {}

  sendFriendInvite(userId: number, id: number) {
    return this.http.post(this.baseUrl + 'invites/' + userId + '/friend/' + id, {});
  }

  getInvites(page?, itemsPerPage?): Observable<PaginatedResult<Invite[]>> {
    const paginatedResult: PaginatedResult<Invite[]> = new PaginatedResult<
      Invite[]
    >();
    const userId = this.authService.decodedToken.nameid;
    let params = new HttpParams();

    if (page != null && itemsPerPage != null) {
      params = params.append('pageNumber', page);
      params = params.append('pageSize', itemsPerPage);
    }

    return this.http
      .get<Invite[]>(this.baseUrl + 'invites/' + userId, { observe: 'response', params })
      .pipe(
        map((response) => {
          paginatedResult.result = response.body;
          if (response.headers.get('Pagination') != null) {
            paginatedResult.pagination = JSON.parse(
              response.headers.get('Pagination')
            );
          }
          return paginatedResult;
        })
      );
  }

  acceptFriendInvite(userId: number, id: number) {
    return this.http.put(this.baseUrl + 'invites/' + userId + '/friend/' + id, {});
  }

  declineFriendInvite(userId: number, id: number) {
    return this.http.delete(this.baseUrl + 'invites/' + userId + '/friend/' + id);
  }

  acceptTeamInvite(userId: number, teamId: number, id: number) {
    return this.http.put(this.baseUrl + 'invites/' + userId + '/team/' + teamId + '/' + id, {});
  }

  declineTeamInvite(userId: number, teamId: number, id: number) {
    return this.http.delete(this.baseUrl + 'invites/' + userId + '/team/' + teamId + '/' + id);
  }

  sendTeamInvite(userId: number, teamId: number, id: number) {
    return this.http.post(this.baseUrl + 'invites/' + userId + '/team/' + teamId + '/' + id, {});
  }

  acceptMatchInvite(userId: number, firstTeamId: number, secondTeamId: number) {
    return this.http.put(this.baseUrl + 'invites/' + userId + '/match/' + firstTeamId + '/' + secondTeamId, {});
  }

  declineMatchInvite(userId: number, firstTeamId: number, secondTeamId: number) {
    return this.http.delete(this.baseUrl + 'invites/' + userId + '/match/' + firstTeamId + '/' + secondTeamId);
  }

  sendMatchInvite(userId: number, firstTeamId: number, secondTeamId: number) {
    return this.http.post(this.baseUrl + 'invites/' + userId + '/match/' + firstTeamId + '/' + secondTeamId, {});
  }

  acceptRefereeInvite(userId: number, matchId: number) {
    return this.http.put(this.baseUrl + 'invites/' + userId + '/match/' + matchId + '/referee', {});
  }

  declineRefereeInvite(userId: number, matchId: number) {
    return this.http.delete(this.baseUrl + 'invites/' + userId + '/match/' + matchId + '/referee');
  }

  sendRefereeInvite(userId: number, refereeId: number, matchId: number) {
    return this.http.post(this.baseUrl + 'invites/' + userId + '/match/' + matchId + '/' + refereeId + '/referee', {});
  }
}
