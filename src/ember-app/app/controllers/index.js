import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.9.caption'),
          title: i18n.t('forms.application.sitemap.9.title'),
          children: [{
            link: 'i-i-s-9-регистр-l',
            caption: i18n.t('forms.application.sitemap.9.i-i-s-9-регистр-l.caption'),
            title: i18n.t('forms.application.sitemap.9.i-i-s-9-регистр-l.title'),
            icon: 'tasks',
            children: null
          }, {
            link: 'i-i-s-9-сотрудник-l',
            caption: i18n.t('forms.application.sitemap.9.i-i-s-9-сотрудник-l.caption'),
            title: i18n.t('forms.application.sitemap.9.i-i-s-9-сотрудник-l.title'),
            icon: 'tasks',
            children: null
          }, {
            link: 'i-i-s-9-заявка-l',
            caption: i18n.t('forms.application.sitemap.9.i-i-s-9-заявка-l.caption'),
            title: i18n.t('forms.application.sitemap.9.i-i-s-9-заявка-l.title'),
            icon: 'paperclip',
            children: null
          }, {
            link: 'i-i-s-9-записи-l',
            caption: i18n.t('forms.application.sitemap.9.i-i-s-9-записи-l.caption'),
            title: i18n.t('forms.application.sitemap.9.i-i-s-9-записи-l.title'),
            icon: 'phone',
            children: null
          }, {
            link: 'i-i-s-9-должности-l',
            caption: i18n.t('forms.application.sitemap.9.i-i-s-9-должности-l.caption'),
            title: i18n.t('forms.application.sitemap.9.i-i-s-9-должности-l.title'),
            icon: 'archive',
            children: null
          }, {
            link: 'i-i-s-9-контрагент-l',
            caption: i18n.t('forms.application.sitemap.9.i-i-s-9-контрагент-l.caption'),
            title: i18n.t('forms.application.sitemap.9.i-i-s-9-контрагент-l.title'),
            icon: 'tasks',
            children: null
          }]
        }
      ]
    };
  }),
})