import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TrainingComponent } from './training/training.component';
import { NgxPaginationModule } from 'ngx-pagination';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NotesPopupComponent } from './notespopup/notespopup.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { HttpClientModule } from '@angular/common/http';
import { TestComponent } from './test/test.component';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { TrainingDetailsComponent } from './trainingdetails/trainingdetails.component';
import { TrainingandCertificatesComponent } from './trainingand-certificates/trainingand-certificates.component';
import { SignupComponent } from './components/signup/signup.component';
import { LoginComponent } from './components/login/login.component';
import { HomeComponent } from './home/home.component';
import { ContinuelearningComponent } from './continuelearning/continuelearning.component';
import { MostpopularComponent } from './mostpopular/mostpopular.component';
import { FeaturedblogsComponent } from './featuredblogs/featuredblogs.component';
import { SkillquizComponent } from './skillquiz/skillquiz.component';
import { SidesectionComponent } from './sidesection/sidesection.component';
import { MainNavbarComponent } from './main-navbar/main-navbar.component';
import { NavbarComponent } from './navbar/navbar.component';
import { CertificateComponent } from './certificate/certificate.component';
import { DetailsComponent } from './details/details.component';
import { WorksComponent } from './works/works.component';
import { PluginsComponent } from './plugins/plugins.component';
import { TemplatesComponent } from './templates/templates.component';
import { AllComponent } from './all/all.component';
import { BooksandPdfsComponent } from './booksand-pdfs/booksand-pdfs.component';
import { Component1Component } from './component1/component1.component';
import { Continue1Component } from './continue1/continue1.component';
import { ContinuenavbarComponent } from './continuenavbar/continuenavbar.component';
import { ResourceNavbarComponent } from './resource-navbar/resource-navbar.component';
import { DownloadpageComponent } from './downloadpage/downloadpage.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { BlogComponent } from './blog/blog.component';
import { CardComponent } from './card/card.component';
import { PopupComponent } from './popup/popup.component';
import { SecondcardComponent } from './secondcard/secondcard.component';
import { FaqComponent } from './faq/faq.component';
import { FreeresourceNavbarComponent } from './freeresource-navbar/freeresource-navbar.component';
import { AllreviewsComponent } from './allreviews/allreviews.component';
import { RightsideComponent } from './rightside/rightside.component';
import { AboutComponent } from './about/about.component';
import { FooterComponent } from './footer/footer.component';
import { provideToastr } from 'ngx-toastr';
import { provideAnimations } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { UserexpcoursesComponent } from './userexpcourses/userexpcourses.component';


//bread
import { BreadcrumbModule } from "xng-breadcrumb";
import { BreadcrumbService } from 'xng-breadcrumb';
import {MatIconModule} from '@angular/material/icon';

import { AuthorFollowComponent } from './author-follow/author-follow.component';
import { BlogcardComponent } from './blogcard/blogcard.component';
import { CardpopularComponent } from './cardpopular/cardpopular.component';
import { FirstPageComponent } from './first-page/first-page.component';
import { RecommendedComponent } from './recommended/recommended.component';
import { SecondPopularComponent } from './second-popular/second-popular.component';
import { SecondpageComponent } from './secondpage/secondpage.component';
import { TrendingBlogComponent } from './trending-blog/trending-blog.component';
import { TrendingcardComponent } from './trendingcard/trendingcard.component';
import { ViewsecondComponent } from './viewsecond/viewsecond.component';
import { WhotofollowComponent } from './whotofollow/whotofollow.component';
import { NotesComponent } from './notes/notes.component';
import { CctableofcontentsComponent } from './cctableofcontents/cctableofcontents.component';
import { DiscussionComponent } from './discussion/discussion.component';
import { DescriptionComponent } from './description/description.component';
import { ReadmorepopupComponent } from './readmorepopup/readmorepopup.component';
import { ResourcesComponent } from './resources/resources.component';
import { ReviewsComponent } from './reviews/reviews.component';
import { VccoursereviewComponent } from './vccoursereview/vccoursereview.component';
import { VcexercisefilesComponent } from './vcexercisefiles/vcexercisefiles.component';
import { VctableofcontentComponent } from './vctableofcontent/vctableofcontent.component';
import { VctranscriptComponent } from './vctranscript/vctranscript.component';
import { ViewallnotesComponent } from './viewallnotes/viewallnotes.component';
import { ViewcourseComponent } from './viewcourse/viewcourse.component';
import { ViewcoursenavbarComponent } from './viewcoursenavbar/viewcoursenavbar.component';
import { Continue2Component } from './continue2/continue2.component';
import { Continue2navbarComponent } from './continue2navbar/continue2navbar.component';
import { ForgotUserComponent } from './components/forgot-user/forgot-user.component';
import { ReviewComponent } from './review/review.component';
@NgModule({
  declarations: [
    AppComponent,
    TrainingComponent,
    TrainingDetailsComponent,
    NotesPopupComponent,
    TestComponent,
    TrainingandCertificatesComponent,
    AppComponent,
    LoginComponent,
    SignupComponent,
    AppComponent,
    HomeComponent,
    ContinuelearningComponent,
    MostpopularComponent,
    FeaturedblogsComponent,
    SkillquizComponent,
    SidesectionComponent,
    MainNavbarComponent,
    NavbarComponent,
    CertificateComponent,
    DetailsComponent,
    WorksComponent,
    PluginsComponent,
    TemplatesComponent,
    AllComponent,
    Component1Component,
    Continue1Component,
    ContinuenavbarComponent,
    ResourceNavbarComponent,
    DownloadpageComponent,
    SidebarComponent,
    BlogComponent,
    CardComponent,
    PopupComponent,
    SecondcardComponent,
    FaqComponent,
    FreeresourceNavbarComponent,
    BooksandPdfsComponent,
    AllreviewsComponent,
    RightsideComponent,
    AboutComponent,
    FooterComponent,
    AuthorFollowComponent,
    BlogcardComponent,
    CardpopularComponent,
    FirstPageComponent,
    RecommendedComponent,
    SecondPopularComponent,
    SecondpageComponent,
    TrendingcardComponent,
    TrendingBlogComponent,
    ViewsecondComponent,
    WhotofollowComponent,
    UserexpcoursesComponent,
    CctableofcontentsComponent,
    NotesComponent,
    DiscussionComponent,
    DescriptionComponent,
    ReadmorepopupComponent,
    ResourcesComponent,
    ReviewsComponent,
    VccoursereviewComponent,
    VcexercisefilesComponent,
    VctableofcontentComponent,
    VctranscriptComponent,
    ViewallnotesComponent,
    ViewcourseComponent,
    ViewcoursenavbarComponent,
    Continue2Component,
    Continue2navbarComponent,

    ReviewComponent,
    ForgotUserComponent



  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatDialogModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    NgxPaginationModule,
    ToastrModule,
    ToastrModule.forRoot(),
    BreadcrumbModule,
    MatIconModule,
    

    
    
  ],
  providers: [
    provideAnimations(), 
    provideToastr(),
    BreadcrumbService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
export interface Review {
  title: string;
  description: string;
}
