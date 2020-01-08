namespace k8s.Models
{
    public partial class V1MutatingWebhookConfiguration : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "MutatingWebhookConfiguration";
        private const string kubeGroup = "admissionregistration.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1MutatingWebhookConfigurationList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "MutatingWebhookConfigurationList";
        private const string kubeGroup = "admissionregistration.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ValidatingWebhookConfiguration : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ValidatingWebhookConfiguration";
        private const string kubeGroup = "admissionregistration.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ValidatingWebhookConfigurationList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ValidatingWebhookConfigurationList";
        private const string kubeGroup = "admissionregistration.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1MutatingWebhookConfiguration : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "MutatingWebhookConfiguration";
        private const string kubeGroup = "admissionregistration.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1MutatingWebhookConfigurationList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "MutatingWebhookConfigurationList";
        private const string kubeGroup = "admissionregistration.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1ValidatingWebhookConfiguration : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "ValidatingWebhookConfiguration";
        private const string kubeGroup = "admissionregistration.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1ValidatingWebhookConfigurationList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "ValidatingWebhookConfigurationList";
        private const string kubeGroup = "admissionregistration.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ControllerRevision : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ControllerRevision";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ControllerRevisionList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ControllerRevisionList";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1DaemonSet : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "DaemonSet";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1DaemonSetList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "DaemonSetList";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1Deployment : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "Deployment";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1DeploymentList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "DeploymentList";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ReplicaSet : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ReplicaSet";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ReplicaSetList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ReplicaSetList";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1StatefulSet : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "StatefulSet";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1StatefulSetList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "StatefulSetList";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1ControllerRevision : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "ControllerRevision";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1ControllerRevisionList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "ControllerRevisionList";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1StatefulSet : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "StatefulSet";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1StatefulSetList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "StatefulSetList";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta2ControllerRevision : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta2";
        private const string kubeKind = "ControllerRevision";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta2ControllerRevisionList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta2";
        private const string kubeKind = "ControllerRevisionList";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta2DaemonSet : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta2";
        private const string kubeKind = "DaemonSet";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta2DaemonSetList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta2";
        private const string kubeKind = "DaemonSetList";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta2Deployment : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta2";
        private const string kubeKind = "Deployment";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta2DeploymentList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta2";
        private const string kubeKind = "DeploymentList";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta2ReplicaSet : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta2";
        private const string kubeKind = "ReplicaSet";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta2ReplicaSetList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta2";
        private const string kubeKind = "ReplicaSetList";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta2Scale : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta2";
        private const string kubeKind = "Scale";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta2StatefulSet : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta2";
        private const string kubeKind = "StatefulSet";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta2StatefulSetList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta2";
        private const string kubeKind = "StatefulSetList";
        private const string kubeGroup = "apps";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1AuditSink : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "AuditSink";
        private const string kubeGroup = "auditregistration.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1AuditSinkList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "AuditSinkList";
        private const string kubeGroup = "auditregistration.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1TokenRequest : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "TokenRequest";
        private const string kubeGroup = "authentication.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1TokenReview : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "TokenReview";
        private const string kubeGroup = "authentication.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1TokenReview : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "TokenReview";
        private const string kubeGroup = "authentication.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1LocalSubjectAccessReview : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "LocalSubjectAccessReview";
        private const string kubeGroup = "authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1SelfSubjectAccessReview : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "SelfSubjectAccessReview";
        private const string kubeGroup = "authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1SelfSubjectRulesReview : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "SelfSubjectRulesReview";
        private const string kubeGroup = "authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1SubjectAccessReview : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "SubjectAccessReview";
        private const string kubeGroup = "authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1LocalSubjectAccessReview : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "LocalSubjectAccessReview";
        private const string kubeGroup = "authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1SelfSubjectAccessReview : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "SelfSubjectAccessReview";
        private const string kubeGroup = "authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1SelfSubjectRulesReview : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "SelfSubjectRulesReview";
        private const string kubeGroup = "authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1SubjectAccessReview : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "SubjectAccessReview";
        private const string kubeGroup = "authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1HorizontalPodAutoscaler : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "HorizontalPodAutoscaler";
        private const string kubeGroup = "autoscaling";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1HorizontalPodAutoscalerList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "HorizontalPodAutoscalerList";
        private const string kubeGroup = "autoscaling";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1Scale : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "Scale";
        private const string kubeGroup = "autoscaling";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V2beta1HorizontalPodAutoscaler : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v2beta1";
        private const string kubeKind = "HorizontalPodAutoscaler";
        private const string kubeGroup = "autoscaling";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V2beta1HorizontalPodAutoscalerList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v2beta1";
        private const string kubeKind = "HorizontalPodAutoscalerList";
        private const string kubeGroup = "autoscaling";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V2beta2HorizontalPodAutoscaler : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v2beta2";
        private const string kubeKind = "HorizontalPodAutoscaler";
        private const string kubeGroup = "autoscaling";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V2beta2HorizontalPodAutoscalerList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v2beta2";
        private const string kubeKind = "HorizontalPodAutoscalerList";
        private const string kubeGroup = "autoscaling";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1Job : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "Job";
        private const string kubeGroup = "batch";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1JobList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "JobList";
        private const string kubeGroup = "batch";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1CronJob : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "CronJob";
        private const string kubeGroup = "batch";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1CronJobList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "CronJobList";
        private const string kubeGroup = "batch";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V2alpha1CronJob : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v2alpha1";
        private const string kubeKind = "CronJob";
        private const string kubeGroup = "batch";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V2alpha1CronJobList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v2alpha1";
        private const string kubeKind = "CronJobList";
        private const string kubeGroup = "batch";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1CertificateSigningRequest : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "CertificateSigningRequest";
        private const string kubeGroup = "certificates.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1CertificateSigningRequestList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "CertificateSigningRequestList";
        private const string kubeGroup = "certificates.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1Lease : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "Lease";
        private const string kubeGroup = "coordination.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1LeaseList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "LeaseList";
        private const string kubeGroup = "coordination.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1Lease : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "Lease";
        private const string kubeGroup = "coordination.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1LeaseList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "LeaseList";
        private const string kubeGroup = "coordination.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1Binding : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "Binding";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ComponentStatus : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ComponentStatus";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ComponentStatusList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ComponentStatusList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ConfigMap : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ConfigMap";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ConfigMapList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ConfigMapList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1Endpoints : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "Endpoints";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1EndpointsList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "EndpointsList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1Event : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "Event";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1EventList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "EventList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1LimitRange : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "LimitRange";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1LimitRangeList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "LimitRangeList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1Namespace : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "Namespace";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1NamespaceList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "NamespaceList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1Node : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "Node";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1NodeList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "NodeList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1PersistentVolume : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "PersistentVolume";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1PersistentVolumeClaim : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "PersistentVolumeClaim";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1PersistentVolumeClaimList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "PersistentVolumeClaimList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1PersistentVolumeList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "PersistentVolumeList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1Pod : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "Pod";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1PodList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "PodList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1PodTemplate : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "PodTemplate";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1PodTemplateList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "PodTemplateList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ReplicationController : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ReplicationController";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ReplicationControllerList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ReplicationControllerList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ResourceQuota : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ResourceQuota";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ResourceQuotaList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ResourceQuotaList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1Secret : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "Secret";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1SecretList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "SecretList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1Service : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "Service";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ServiceAccount : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ServiceAccount";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ServiceAccountList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ServiceAccountList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ServiceList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ServiceList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1EndpointSlice : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "EndpointSlice";
        private const string kubeGroup = "discovery.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1EndpointSliceList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "EndpointSliceList";
        private const string kubeGroup = "discovery.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1Event : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "Event";
        private const string kubeGroup = "events.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1EventList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "EventList";
        private const string kubeGroup = "events.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1DaemonSet : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "DaemonSet";
        private const string kubeGroup = "extensions";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1DaemonSetList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "DaemonSetList";
        private const string kubeGroup = "extensions";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1NetworkPolicy : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "NetworkPolicy";
        private const string kubeGroup = "extensions";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1NetworkPolicyList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "NetworkPolicyList";
        private const string kubeGroup = "extensions";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1ReplicaSet : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "ReplicaSet";
        private const string kubeGroup = "extensions";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1ReplicaSetList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "ReplicaSetList";
        private const string kubeGroup = "extensions";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1NetworkPolicy : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "NetworkPolicy";
        private const string kubeGroup = "networking.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1NetworkPolicyList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "NetworkPolicyList";
        private const string kubeGroup = "networking.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1RuntimeClass : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "RuntimeClass";
        private const string kubeGroup = "node.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1RuntimeClassList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "RuntimeClassList";
        private const string kubeGroup = "node.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1RuntimeClass : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "RuntimeClass";
        private const string kubeGroup = "node.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1RuntimeClassList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "RuntimeClassList";
        private const string kubeGroup = "node.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1Eviction : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "Eviction";
        private const string kubeGroup = "policy";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1PodDisruptionBudget : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "PodDisruptionBudget";
        private const string kubeGroup = "policy";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1PodDisruptionBudgetList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "PodDisruptionBudgetList";
        private const string kubeGroup = "policy";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ClusterRole : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ClusterRole";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ClusterRoleBinding : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ClusterRoleBinding";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ClusterRoleBindingList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ClusterRoleBindingList";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1ClusterRoleList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "ClusterRoleList";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1Role : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "Role";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1RoleBinding : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "RoleBinding";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1RoleBindingList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "RoleBindingList";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1RoleList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "RoleList";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1ClusterRole : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "ClusterRole";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1ClusterRoleBinding : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "ClusterRoleBinding";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1ClusterRoleBindingList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "ClusterRoleBindingList";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1ClusterRoleList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "ClusterRoleList";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1Role : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "Role";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1RoleBinding : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "RoleBinding";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1RoleBindingList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "RoleBindingList";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1RoleList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "RoleList";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1ClusterRole : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "ClusterRole";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1ClusterRoleBinding : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "ClusterRoleBinding";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1ClusterRoleBindingList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "ClusterRoleBindingList";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1ClusterRoleList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "ClusterRoleList";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1Role : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "Role";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1RoleBinding : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "RoleBinding";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1RoleBindingList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "RoleBindingList";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1RoleList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "RoleList";
        private const string kubeGroup = "rbac.authorization.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1PriorityClass : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "PriorityClass";
        private const string kubeGroup = "scheduling.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1PriorityClassList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "PriorityClassList";
        private const string kubeGroup = "scheduling.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1PriorityClass : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "PriorityClass";
        private const string kubeGroup = "scheduling.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1PriorityClassList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "PriorityClassList";
        private const string kubeGroup = "scheduling.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1PriorityClass : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "PriorityClass";
        private const string kubeGroup = "scheduling.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1PriorityClassList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "PriorityClassList";
        private const string kubeGroup = "scheduling.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1PodPreset : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "PodPreset";
        private const string kubeGroup = "settings.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1PodPresetList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "PodPresetList";
        private const string kubeGroup = "settings.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1StorageClass : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "StorageClass";
        private const string kubeGroup = "storage.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1StorageClassList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "StorageClassList";
        private const string kubeGroup = "storage.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1VolumeAttachment : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "VolumeAttachment";
        private const string kubeGroup = "storage.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1VolumeAttachmentList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "VolumeAttachmentList";
        private const string kubeGroup = "storage.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1VolumeAttachment : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "VolumeAttachment";
        private const string kubeGroup = "storage.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1alpha1VolumeAttachmentList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1alpha1";
        private const string kubeKind = "VolumeAttachmentList";
        private const string kubeGroup = "storage.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1CSIDriver : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "CSIDriver";
        private const string kubeGroup = "storage.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1CSIDriverList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "CSIDriverList";
        private const string kubeGroup = "storage.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1CSINode : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "CSINode";
        private const string kubeGroup = "storage.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1CSINodeList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "CSINodeList";
        private const string kubeGroup = "storage.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1StorageClass : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "StorageClass";
        private const string kubeGroup = "storage.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1StorageClassList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "StorageClassList";
        private const string kubeGroup = "storage.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1VolumeAttachment : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "VolumeAttachment";
        private const string kubeGroup = "storage.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1VolumeAttachmentList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "VolumeAttachmentList";
        private const string kubeGroup = "storage.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1CustomResourceDefinition : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "CustomResourceDefinition";
        private const string kubeGroup = "apiextensions.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1CustomResourceDefinitionList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "CustomResourceDefinitionList";
        private const string kubeGroup = "apiextensions.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1CustomResourceDefinition : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "CustomResourceDefinition";
        private const string kubeGroup = "apiextensions.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1CustomResourceDefinitionList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "CustomResourceDefinitionList";
        private const string kubeGroup = "apiextensions.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1APIGroup : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "APIGroup";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1APIGroupList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "APIGroupList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1APIResourceList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "APIResourceList";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1APIVersions : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "APIVersions";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1DeleteOptions : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "DeleteOptions";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1Status : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "Status";
        private const string kubeGroup = "";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1APIService : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "APIService";
        private const string kubeGroup = "apiregistration.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1APIServiceList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1";
        private const string kubeKind = "APIServiceList";
        private const string kubeGroup = "apiregistration.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1APIService : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "APIService";
        private const string kubeGroup = "apiregistration.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

    public partial class V1beta1APIServiceList : IKubernetesObject, IKubernetesTypes
    {
        private const string kubeApiVersion = "v1beta1";
        private const string kubeKind = "APIServiceList";
        private const string kubeGroup = "apiregistration.k8s.io";
        public string KubeApiVersion { get { return kubeApiVersion;} }
        public string KubeKind {get {return kubeKind;}}
        public string KubeGroup {get {return kubeGroup;}}
    }

}
