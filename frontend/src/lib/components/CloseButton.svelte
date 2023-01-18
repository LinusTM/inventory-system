<script lang="ts">
	export let onClose: any;
</script>

<button type="button" on:click={onClose}
	><svg
		height="28"
		shape-rendering="geometricPrecision"
		stroke-linecap="round"
		stroke-linejoin="round"
		stroke-width="1.5"
		viewBox="0 0 24 24"
		width="28"><circle cx="12" cy="12" r="10" /><path d="M15 9l-6 6" /><path d="M9 9l6 6" /></svg
	>
</button>

<style lang="scss">
	svg {
		background-color: none;
		border: none;
		stroke: var(--text-primary);
		fill: none;
	}

	button {
		position: absolute;
		top: 4px;
		right: 0;
		background: none;
		border: none;
	}
</style>
